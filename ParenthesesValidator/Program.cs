using System;

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
}
