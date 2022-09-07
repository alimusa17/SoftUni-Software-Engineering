using System;

namespace _03._Movie_Destination_SWITCH_CASE
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string destination = Console.ReadLine(); 
            string season = Console.ReadLine(); 
            int days = int.Parse(Console.ReadLine());

            double pricePerDay = 0;
            switch (destination)
            {
                case "Dubai":
                    switch (season)
                    {
                        case "Summer": pricePerDay = 40000; break;
                        case "Winter": pricePerDay = 45000; break;
                    }
                    break;
                case "Sofia":
                    switch (season)
                    {
                        case "Summer": pricePerDay = 12500; break;
                        case "Winter": pricePerDay = 17000; break;
                    }
                    break;
                case "London":
                    switch (season)
                    {
                        case "Summer": pricePerDay = 20250; break;
                        case "Winter": pricePerDay = 24000; break;
                    }
                    break;

            }

            double totalPrice = pricePerDay * days;

            if (destination == "Dubai")
            {
                totalPrice = totalPrice * 0.7;
            }
            else if (destination == "Sofia")
            {
                totalPrice = totalPrice * 1.25;

            }

            if (budget >= totalPrice)
            {
                double leftMoney = budget - totalPrice;
                Console.WriteLine($"The budget for the movie is enough! We have {leftMoney:F2} leva left!");
            }
            else
            {
                double needMoney = totalPrice - budget;
                Console.WriteLine($"The director needs {needMoney:F2} leva more!");
            }
        }
    }
}
