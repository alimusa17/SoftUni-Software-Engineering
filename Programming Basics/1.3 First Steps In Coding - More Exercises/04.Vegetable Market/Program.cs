using System;

namespace _04.Vegetable_Market
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceKgVeg = double.Parse(Console.ReadLine());
            double priceKgFruit = double.Parse(Console.ReadLine());
            int totalKgVeg = int.Parse(Console.ReadLine());
            int totalKgFruit = int.Parse(Console.ReadLine());

            double priceVeg = priceKgVeg * totalKgVeg;
            double priceFruit = priceKgFruit * totalKgFruit;

            double totalSum = (priceVeg + priceFruit) / 1.94;

            Console.WriteLine($"{totalSum:f2}");
        }
    }
}
