using System;
using System.Linq;

namespace EqualSums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < arr1.Length; i++)
            {
                int left = 0;
                int right = 0;

                for (int j = 0; j < i; j++)
                {
                    left += arr1[j];

                }
                for (int k = i + 1; k < arr1.Length; k++)
                {
                    right += arr1[k];
                }
                if (left == right)
                {
                    Console.WriteLine(i);
                    return;
                }
            }

            Console.WriteLine("no");

        }
    }
}
