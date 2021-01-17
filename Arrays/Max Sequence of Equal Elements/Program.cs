using System;

namespace Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split();
            int bestCount = 0;
            int bestIndex = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                string currNumber = arr[i];
                int count = 1;

                for (int j = i + 1; j < arr.Length; j++)
                {
                    string secondNum = arr[j];
                    if (currNumber == secondNum)
                    {
                        count++;
                    }
                    else
                    {
                        break;
                    }
                }

                if (count > bestCount)
                {
                    bestCount = count;
                    bestIndex = i;
                }
            }

            for (int i = 0; i < bestCount; i++)
            {
                Console.Write(arr[bestIndex] + " ");
            }
        }
    }
}
