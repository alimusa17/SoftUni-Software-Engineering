using System;

namespace _03._Flowers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfChrysanthemums = int.Parse(Console.ReadLine());
            int numberOfRoses = int.Parse(Console.ReadLine());
            int numbersOfTulip = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string holiday = Console.ReadLine();


            if (season == "Spring" || season == "Summer")
            {
                int totalFlowers = numberOfChrysanthemums + numberOfRoses + numbersOfTulip;

                double priceChrysanthemums = numberOfChrysanthemums * 2;
                double priceRoses = numberOfRoses * 4.1;
                double priceTulip = numbersOfTulip * 2.5;

                double totalPrice = priceChrysanthemums + priceRoses + priceTulip;

                if (holiday == "Y")
                {
                    totalPrice = totalPrice * 1.15;                         // totalPrice + 15%      
                }
                if (numbersOfTulip > 5 && season == "Spring")
                {
                    totalPrice = totalPrice * 0.95;
                }
                if (totalFlowers >= 20)
                {
                    totalPrice = totalPrice * 0.8;
                }

                Console.WriteLine($"{2 + totalPrice:F2}");
            }
            else
            {
                int totalFlowers = numberOfChrysanthemums + numberOfRoses + numbersOfTulip;

                double priceChrysanthemums = numberOfChrysanthemums * 3.75;
                double priceRoses = numberOfRoses * 4.5;
                double priceTulip = numbersOfTulip * 4.15;

                double totalPrice = priceChrysanthemums + priceRoses + priceTulip;

                if (holiday == "Y")
                {
                    totalPrice = totalPrice * 1.15;                         // totalPrice + 15%   
                }
                if (numberOfRoses >= 10 && season == "Winter")
                {
                    totalPrice = totalPrice * 0.9;
                }
                if (totalFlowers >= 20)
                {
                    totalPrice = totalPrice * 0.8;
                }

                Console.WriteLine($"{2 + totalPrice:F2}");
            }
        }
    }
}

