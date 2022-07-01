using System;

namespace _03._Snooker
{
    class Program
    {
        static void Main(string[] args)
        {
            string round = Console.ReadLine();
            string ticketType = Console.ReadLine();
            int ticketCount = int.Parse(Console.ReadLine());
            bool pickTrophy = Console.ReadLine() == "Y";

            double totalSum = 0;
            double ticketPrice = 0;

            switch (round)
            {
                case "Standard":
                    if (ticketType == "Quarter final")
                    {
                        ticketPrice = 55.5;
                    }
                    else if (ticketType == "Semi final")
                    {
                        ticketPrice = 75.88;
                    }
                    else if (ticketType == "Final")
                    {
                        ticketPrice = 110.10;
                    }
                    break;

                case "Premium":
                    if (ticketType == "Quarter final")
                    {
                        ticketPrice = 105.2;
                    }
                    else if (ticketType == "Semi final")
                    {
                        ticketPrice = 125.22;
                    }
                    else if (ticketType == "Final")
                    {
                        ticketPrice = 160.66;
                    }
                    break;

                case "VIP":
                    if (ticketType == "Quarter final")
                    {
                        ticketPrice = 118.9;
                    }
                    else if (ticketType == "Semi final")
                    {
                        ticketPrice = 300.4;
                    }
                    else if (ticketType == "Final")
                    {
                        ticketPrice = 400;
                    }
                    break;
            }

            totalSum = ticketCount * ticketPrice;

            Console.WriteLine($"{totalSum:f2}");
        }
    }
}
