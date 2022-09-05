using System;

namespace _02._Family_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());
            double nightPrice = double.Parse(Console.ReadLine());
            int extraCost = int.Parse(Console.ReadLine());

            if (nights > 7)
            {
                nightPrice *= 0.95;
            }

            double nightsPrice = nights * nightPrice;

            double percentExtraCost = budget * extraCost / 100; 

            double totalPrice = nightsPrice + percentExtraCost;

            if (budget >= totalPrice)
            {
                Console.WriteLine($"Ivanovi will be left with {budget - totalPrice:f2} leva after vacation.");
            }
            else
            {
                Console.WriteLine($"{(totalPrice - budget):f2} leva needed.");
            }

        }
    }
}
