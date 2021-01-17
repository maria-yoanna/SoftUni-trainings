using System;

namespace Password
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            bool isCharacters = Characters(input);
            bool isLetterAndDigit = LetterAndDigit(input);
            bool isTwoDigits = TwoDigits(input);

            if (isCharacters && isLetterAndDigit && isTwoDigits)
            {
                Console.WriteLine("Password is valid");
            }
            else
            {
                if (!isCharacters)
                {
                    Console.WriteLine("Password must be between 6 and 10 characters");
                }

                if (!isLetterAndDigit)
                {
                    Console.WriteLine("Password must consist only of letters and digits");
                }

                if (!isTwoDigits)
                {
                    Console.WriteLine("Password must have at least 2 digits");
                }
            }
        }

        private static bool Characters(string input)
        {

                if (input.Length >= 6 && input.Length <= 10)
                {
                return true;
                }
            return false;
            
        }

        private static bool LetterAndDigit(string input)
        {
            foreach (char c in input)
            {
                if (!char.IsLetterOrDigit(c))
                {
                    return false;
                }
            }
            return true;
        }

        private static bool TwoDigits(string input)
        {
            int counter = 0;
            foreach (char c in input)
            {
                if (char.IsDigit(c))
                {
                    counter++;
                }
            }
            if (counter >= 2)
            {
                return true;
            }
            return false;
        }

    }
}
