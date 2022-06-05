using System;

namespace _07._Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());

            int videocardQuantity = int.Parse(Console.ReadLine());
            int processorsQuantity = int.Parse(Console.ReadLine());
            int ramMemoryQuantity = int.Parse(Console.ReadLine());

            double videocardPrice = videocardQuantity * 250;
            double processorsPrice = processorsQuantity * (videocardPrice * 0.35);
            double ramMemoryPrice = ramMemoryQuantity * (videocardPrice * 0.10);

            double totalPrice = videocardPrice + processorsPrice + ramMemoryPrice;

            if (videocardQuantity >= processorsQuantity)
            {
                totalPrice = totalPrice - (totalPrice * 0.15);
            }

            double difference = budget - totalPrice;

            if (difference >= 0)
            {
                Console.WriteLine($"You have {difference:f2} leva left!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {Math.Abs(difference):f2} leva more!");
            }
        }
    }
}
