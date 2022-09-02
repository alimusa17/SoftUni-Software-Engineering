using System;

namespace _01._Match_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string category = Console.ReadLine();
            int peopleInGroup = int.Parse(Console.ReadLine());

            double vip = 499.99;
            double normal = 249.99;

            double totalMoney = 0;
            double ticketPrice = 0;

            if (peopleInGroup <= 4)
            {
                totalMoney = budget * 0.25;                 //75%
            }
            else if (peopleInGroup <= 9)
            {
                totalMoney = budget * 0.4;                  //60%
            }
            else if (peopleInGroup <= 24)
            {
                totalMoney = budget * 0.5;                  //50%
            }
            else if (peopleInGroup <= 49)
            {
                totalMoney = budget * 0.6;                  //40%
            }
            else if (peopleInGroup >= 50)
            {
                totalMoney = budget * 0.75;                 //25%
            }

            if (category == "Normal")
            {
                ticketPrice = normal * peopleInGroup;
            }

            if (category == "VIP")
            {
                ticketPrice = vip * peopleInGroup;
            }

            if (totalMoney >= ticketPrice)
            {
                Console.WriteLine($"Yes! You have {totalMoney - ticketPrice:F2} leva left.");
            }

            else
            {
                Console.WriteLine($"Not enough money! You need {ticketPrice - totalMoney:F2} leva.");
            }
        }
    }
}
