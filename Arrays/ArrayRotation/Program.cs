using System;
using System.Linq;

namespace ArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int theFirstElement = array[0];
                // array[array.Length - 1] = theFirstElement;
                int[] temp = new int[array.Length];

                for (int j = 1; j < array.Length; j++)
                {
                    temp[j - 1] = array[j];

                }

                temp[temp.Length - 1] = theFirstElement;
                array = temp;
            }

            Console.WriteLine(string.Join(' ',array));             
        }
    }
}
