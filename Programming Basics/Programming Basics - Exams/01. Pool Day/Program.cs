using System;

namespace _1.PoolDay
{
    class Program
    {
        static void Main(string[] args)
        {
            int persons = int.Parse(Console.ReadLine());
            double taxPerPerson = double.Parse(Console.ReadLine());
            double loungePrice = double.Parse(Console.ReadLine());
            double umbrellaPrice = double.Parse(Console.ReadLine());

            double taxEntry = persons * taxPerPerson;

            double neededLounge = persons * 0.75;

            double neededLoungePrice = Math.Ceiling(neededLounge) * loungePrice;

            double neededUmbrella = persons * 0.5;

            double neededUmbrellaPrice = Math.Ceiling(neededUmbrella) * umbrellaPrice;

            double totalsum = taxEntry + neededLoungePrice + neededUmbrellaPrice;

            Console.WriteLine($"{totalsum:f2} lv.");

        }
    }
}
