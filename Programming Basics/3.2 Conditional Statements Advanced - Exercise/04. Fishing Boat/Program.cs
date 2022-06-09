using System;

namespace _04._Fishing_Boat
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishermen = int.Parse(Console.ReadLine());

            double price = 0;

            switch (season)
            {
                case "Spring":
                    price = 3000;
                    break;
                case "Summer":
                case "Autumn":
                    price = 4200;
                    break;
                case "Winter":
                    price = 2600;
                    break;
                default:
                    break;
            }
            if (fishermen <= 6)
            {
                price *= 0.9;
            }
            else if (fishermen <= 11)
            {
                price *= 0.85;
            }
            else
            {
                price = price - price * 0.25;
            }
            if (fishermen % 2 == 0 && season != "Autumn")
            {
                price -= price * 0.05;
            }
            if (budget >= price)
            {
                Console.WriteLine($"Yes! You have {(budget - price):f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {(price - budget):f2} leva.");
            }

        }
    }
}
