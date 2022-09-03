using System;

namespace _10._Multiply_by_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double numbers = 0;
            double sum = numbers * 2;

            while (numbers >= 0)
            {
                numbers = double.Parse(Console.ReadLine());

                if (numbers >= 0)
                {
                    numbers *= 2;
                    Console.WriteLine($"Result: {numbers:F2}");
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine("Negative number!");
        }
    }
}

