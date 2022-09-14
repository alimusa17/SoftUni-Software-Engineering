using System;

namespace _02._Report_System
{
    class Program
    {
        static void Main(string[] args)
        {
            int neededMoney = int.Parse(Console.ReadLine());

            int peopleCash = 0;
            int peopleCard = 0;
            int counter = 0;
            int payedCash = 0;
            int payedCard = 0;
            string input = Console.ReadLine();

            while (input != "End")
            {
                int price = int.Parse(input);
                if (counter % 2 == 0)
                {
                    if (price > 100)
                    {
                        Console.WriteLine("Error in transaction!");
                    }
                    else
                    {
                        payedCash += price;
                        peopleCash++;
                        Console.WriteLine("Product sold!");
                    }
                }
                else
                {
                    if (price < 10)
                    {
                        Console.WriteLine("Error in transaction!");
                    }
                    else
                    {
                        payedCard += price;
                        peopleCard++;
                        Console.WriteLine("Product sold!");
                    }
                }

                if (payedCash + payedCard >= neededMoney)
                {
                    break;
                }
                counter++;
                input = Console.ReadLine();
            }

            if (input == "End")
            {
                Console.WriteLine("Failed to collect required money for charity.");
            }
            else
            {
                double averageCash = (double)payedCash / peopleCash;
                double averageCard = (double)payedCard / peopleCard;

                Console.WriteLine($"Average CS: {averageCash:f2}");
                Console.WriteLine($"Average CC: {averageCard:f2}");
            }
        }
    }
}
