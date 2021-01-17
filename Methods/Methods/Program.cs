using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumer = int.Parse(Console.ReadLine());
            int secondNumer = int.Parse(Console.ReadLine());
            int thirdNumer = int.Parse(Console.ReadLine());

            PrintSmallestNumber(firstNumer, secondNumer, thirdNumer); 
           
        }

        private static void PrintSmallestNumber(int firstNumer, int secondNumer, int thirdNumer)
        {
            if(firstNumer < secondNumer && firstNumer < thirdNumer)
            {
                Console.WriteLine(firstNumer);
            }
            else if (secondNumer < firstNumer && secondNumer < thirdNumer)
            {
                Console.WriteLine(secondNumer);
            }
            else
            {
                Console.WriteLine(thirdNumer);
            }
        }
    }
}
