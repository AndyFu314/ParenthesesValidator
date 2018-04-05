using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParenthesesValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a parentheses string to validate:");

            while (true)
            {
                var parenthesesString = Console.ReadLine();

                if (parenthesesString.IsValidParentheses())
                {
                    Console.WriteLine("The string is valid.");
                }
                else
                {
                    Console.WriteLine("The string is invalid.");
                }
            }
        }


    }

    public static class StringExtension
    {
        public static bool IsValidParentheses(this string sentence)
        {
            // wildcard: 萬用字元(星星數)
            // counter: 計數器(左括號+1, 右括號-1)
            int wildcard = 0, counter = 0;
            bool result = true;

            foreach (var c in sentence)
            {
                switch (c)
                {
                    case '*':
                        wildcard += 1;
                        break;
                    case '(':
                        counter += 1;
                        break;
                    case ')':
                        if (counter > 0)
                        {
                            counter -= 1;
                            result = true;
                        }
                        else if (wildcard > 0)
                        {
                            wildcard -= 1;
                            result = true;
                        }
                        else
                        {
                            return false;
                        }
                        break;
                    default:
                        return false;
                }
            }

            // 檢查最後是否有足夠的星星可以和左括號成對
            // 例如: "**))(((**", "(**)(", "((*)"
            if (counter > 0 && result != false)
            {
                int wildcardFromLast = 0;

                foreach (var c in sentence.Reverse())
                {
                    if (c == '*')
                        wildcardFromLast += 1;
                    else if (c == '(')
                    {
                        // 最後一個括號是左括號, 則以後面的星星數跟counter比較
                        result = wildcardFromLast >= counter ? true : false;
                        break;
                    }
                    else
                    {
                        // 最後一個括號是右括號, 則以字串中的星星數跟counter比較
                        result = wildcard >= counter ? true : false;
                        break;
                    }
                }
            }

            return result;
        }
    }
}
