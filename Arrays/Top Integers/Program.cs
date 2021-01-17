using System;
using System.Linq;

namespace Top_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < arr.Length; i++)
            {
                bool bigger = true;

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] <= arr [j])
                    {
                        bigger = false;
                        break;
                    }

                }
                if (bigger)
                {
                    Console.Write(arr[i] + " ");
                }
                
            }
        }
    }
}
