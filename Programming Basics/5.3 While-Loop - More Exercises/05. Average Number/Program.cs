using System;

namespace _05._Average_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double total = 0.0;

            for (int i = 1; i <= n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                total += number;
            }
            double average = (double)total / n;

            Console.WriteLine("{0:F2}", average);
        }
    }
}
