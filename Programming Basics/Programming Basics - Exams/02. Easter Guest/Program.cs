using System;

namespace _02._Easter_Guest
{
    class Program
    {
        static void Main(string[] args)
        {
            int guest = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double neededEasterBread = Math.Ceiling(guest / 3.0);
            int neededEggs = guest * 2;

            double priceEasterBread = neededEasterBread * 4;
            double egggsPrice = neededEggs * 0.45;

            double totalSum = priceEasterBread + egggsPrice;

            if (totalSum <= budget )
            {
                double moneyLeft = budget - totalSum;
                Console.WriteLine($"Lyubo bought {neededEasterBread} Easter bread and {neededEggs} eggs.");
                Console.WriteLine($"He has {moneyLeft:f2} lv. left.");
            }
            else
            {
                double moneyNeeded = totalSum - budget;
                Console.WriteLine("Lyubo doesn't have enough money.");
                Console.WriteLine($"He needs {moneyNeeded:f2} lv. more.");
            }
        }
    }
}
