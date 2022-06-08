using System;

namespace _03._New_House
{
    class Program
    {
        static void Main(string[] args)
        {
            string flowersType = Console.ReadLine();
            int flowersQuantity = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double price = 0;

            if (flowersType == "Roses")
            {
                price = flowersQuantity * 5.00;
                if (flowersQuantity > 80)
                {
                    price = price - price * 0.10;
                }
            }
            else if (flowersType == "Dahlias")
            {
                price = flowersQuantity * 3.80;
                if (flowersQuantity > 90)
                {
                    price = price - price * 0.15;
                }
            }
            else if (flowersType == "Tulips")
            {
                price = flowersQuantity * 2.80;
                if (flowersQuantity > 80)
                {
                    price = price - price * 0.15;
                }
            }
            else if (flowersType == "Narcissus")
            {
                price = flowersQuantity * 3.00;
                if (flowersQuantity < 120)
                {
                    price = price + price * 0.15;
                }
            }
            else if (flowersType == "Gladiolus")
            {
                price = flowersQuantity * 2.50;
                if (flowersQuantity < 80)
                {
                    price = price + price * 0.20;
                }
            }

            if (budget < price)
            {
                Console.WriteLine($"Not enough money, you need {Math.Abs(price - budget):f2} leva more.");
            }
            else
            {
                Console.WriteLine($"Hey, you have a great garden with {flowersQuantity} {flowersType} and {(budget - price):f2} leva left.");
            }

        }
    }
}
