using System;

namespace _01._Sign_of_Integer_Numbers_by_Authors
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintSign(int.Parse(Console.ReadLine()));
        }

        static void PrintSign(int number)
        {
            if (number > 0)
            {
                Console.WriteLine("The number {0} is positive", number);
            }
            else if (number < 0)
            {
                Console.WriteLine("The number {0} is negative.", number);
            }
            else
            {
                Console.WriteLine("The number {0} is zero.", number);
            }

        }
    }
}
