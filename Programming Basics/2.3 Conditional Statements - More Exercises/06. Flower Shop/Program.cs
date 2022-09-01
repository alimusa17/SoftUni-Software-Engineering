using System;

namespace _06._Flower_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbersMagnolias = int.Parse(Console.ReadLine());
            int numbersHyacinth = int.Parse(Console.ReadLine());
            int numbersRoses = int.Parse(Console.ReadLine());
            int numbersCactus = int.Parse(Console.ReadLine());
            double priceGift = double.Parse(Console.ReadLine());

            double priceMagnolias = numbersMagnolias * 3.25;
            double priceHyacinth = numbersHyacinth * 4;
            double priceRoses = numbersRoses * 3.5;
            double priceCactus = numbersCactus * 8;

            double price = priceMagnolias + priceHyacinth + priceRoses + priceCactus;

            double taxes = price * 0.05;

            double profit = price - taxes;

            if (profit <= priceGift)
            {
                Console.WriteLine($"She will have to borrow {Math.Ceiling(priceGift - profit)} leva.");
            }
            else
            {
                Console.WriteLine($"She is left with {Math.Floor(profit - priceGift)} leva.");
            }
        }
    }
}

