using System;

namespace _01._Sign_of_Integer_Numbers_V2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int number = int.Parse(input);
            PrintSing(number);
        }

        static void PrintSing(int number)
        {
            if (number > 0)
            {
                Console.WriteLine($"The number {number} is positive. ");
            }
            else if (number < 0)
            {
                Console.WriteLine($"The number {number} is negative. ");
            }
            else
            {
                Console.WriteLine($"The number {number} is zero. ");
            }
        }
    }
}
