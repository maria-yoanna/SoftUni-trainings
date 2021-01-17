using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] days = new string[]
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday",
            };

            int numberOfDay = int.Parse(Console.ReadLine());

            if (numberOfDay < 1 || numberOfDay > days.Length)
            {
                Console.WriteLine("Invalid day!");
            }
            else
            {
                Console.WriteLine(days[numberOfDay - 1]);
            }
        }

    }
}
