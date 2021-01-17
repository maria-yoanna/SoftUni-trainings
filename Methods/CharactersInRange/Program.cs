using System;

namespace CharactersInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            char fisrt = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());

            Characters(fisrt, second);
        }

        private static void Characters(char first, char second)
        {
            if (first > second)
            {
                char firstCopy = first;
                first = second;
                second = firstCopy;
            }

            for (int i = first + 1; i < second; i++)
            {
                Console.Write((char)i + " ");
            }
        }
    }
}
