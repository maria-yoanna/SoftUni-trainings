using System;
using System.Linq;

namespace EvenAndOddSubtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                            .Split()
                            .Select(int.Parse)
                            .ToArray();

            int total = 0;
            int even = 0;
            int odd = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int current = numbers[i];


                if (current % 2 == 0)
                {
                    even += current;
                }
                else if (current % 2 == 1)
                {
                    odd += current;
                }
            }

            total = even - odd;

            Console.WriteLine(total);
        }
    }
}
