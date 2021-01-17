using System;

namespace FactorialDivision
{
    class Program
    {

        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            double factoriaFirstNum = Factorial_WhileLoop(firstNumber);
            double factoriaSecondNum = Factorial_WhileLoop(secondNumber);

            double result = factoriaFirstNum / factoriaSecondNum;

            Console.WriteLine($"{result:f2}");

        }

        public static double Factorial_WhileLoop(int number)
        {
                double result = 1;
                while (number != 1)
                {
                    result = result * number;
                    number = number - 1;
                }
                return result;
            
        }   
    }
}
