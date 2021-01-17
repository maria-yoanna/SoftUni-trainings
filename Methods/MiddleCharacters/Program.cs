using System;
using System.Globalization;

namespace MiddleCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            if (input.Length % 2 == 0)
            {
                string output = GetEvenChars(input);
                Console.WriteLine(output);
            }
            else
            {
                string secondOutput = GetOddChar(input);
                Console.WriteLine(secondOutput);
            }
        }

        private static string GetOddChar(string input)
        {
            int index = input.Length / 2;
            string secondChar = input.Substring(index, 1);
            return secondChar;

        }

        private static string GetEvenChars(string input)
        {
            int index = input.Length / 2;
            string chars = input.Substring(index - 1, 2);
            return chars;
        }
    }
}
