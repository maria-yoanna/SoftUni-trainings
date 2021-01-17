using System;
using System.Diagnostics.CodeAnalysis;

namespace AddAndSubtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirtNumber = int.Parse(Console.ReadLine());

            int result = Sum(firstNumber, secondNumber, thirtNumber);
            Console.WriteLine(result);
        }

        private static int Sum(int firstNumber, int secondNumber, int thirtNumber)
        {
            int sum = firstNumber + secondNumber;

            int totalSum = sum - thirtNumber;

            return totalSum;
        }
    }
}
