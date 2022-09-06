using System;

namespace _03._Cofee_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            string drink = Console.ReadLine();
            string sugar = Console.ReadLine();
            int drinksCount = int.Parse(Console.ReadLine());

            double drinkPrice = 0;

            if (sugar == "Without")
            {
                if (drink == "Espresso")
                {
                    drinkPrice = 0.9;
                    if (drinksCount >= 5)
                    {
                        drinkPrice *= 0.75;
                    }
                }
                else if (drink == "Cappuccino")
                {
                    drinkPrice = 1;
                }
                else if (drink == "Tea")
                {
                    drinkPrice = 0.5;
                }

                drinkPrice *= 0.65;
            }
            else if (sugar == "Normal")
            {
                if (drink == "Espresso")
                {
                    drinkPrice = 1;
                    if (drinksCount >= 5)
                    {
                        drinkPrice *= 0.75;
                    }
                }
                else if (drink == "Cappuccino")
                {
                    drinkPrice = 1.2;
                }
                else if (drink == "Tea")
                {
                    drinkPrice = 0.6;
                }
            }
            else if (sugar == "Extra")
            {
                if (drink == "Espresso")
                {
                    drinkPrice = 1.2;
                    if (drinksCount >= 5)
                    {
                        drinkPrice *= 0.75;
                    }
                }
                else if (drink == "Cappuccino")
                {
                    drinkPrice = 1.6;
                }
                else if (drink == "Tea")
                {
                    drinkPrice = 0.7;
                }
            }

            double sum = drinkPrice * drinksCount;

            if (sum > 15)
            {
                sum *= 0.8;
            }

            Console.WriteLine($"You bought {drinksCount} cups of {drink} for {sum:f2} lv.");
        }
    }
}
