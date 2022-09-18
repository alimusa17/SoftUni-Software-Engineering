using System;

namespace _01._Christmas_Preparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int paperCount = int.Parse(Console.ReadLine());
            int platCount = int.Parse(Console.ReadLine());
            double glueLiters = double.Parse(Console.ReadLine());
            int percent = int.Parse(Console.ReadLine());

            double paperPrice = paperCount * 5.80;
            double platPrice = platCount * 7.20;
            double gluePrice = glueLiters * 1.20;

            double sum = paperPrice + platPrice + gluePrice;

            double totalSum = sum - sum * (percent / 100.0);

            Console.WriteLine($"{totalSum:f3}");
        }
    }
}
