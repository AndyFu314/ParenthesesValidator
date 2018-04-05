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
            int wildcard = 0, counter = 0;
            bool result = true;

            foreach (var c in sentence)
            {
                if (c == '*')
                {
                    wildcard += 1;
                }
                else if (c == '(')
                {
                    counter += 1;
                }
                else if (c == ')')
                {
                    if (counter > 0)
                    {
                        counter -= 1;
                        result = true;
                    }
                    else if (wildcard > 0)
                    {
                        wildcard -= 1;
                        result = true;
                    }else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }

            // 檢查最後是否有足夠的星星可以和左括號成對
            // 例如: "**))(((**", "(**)("
            if (counter > 0 && result != false)
            {
                int wildcardFromLast = 0;

                foreach(var c in sentence.Reverse())
                {
                    if (c == '*')
                        wildcardFromLast += 1;
                    else
                        break;
                }

                if (wildcardFromLast >= counter)
                    result = true;
                else
                    result = false;
            }

            return result;
        }
    }
}
