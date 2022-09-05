using System;

namespace _02._Easter_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            int guest = int.Parse(Console.ReadLine());
            double coverPerson = double.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());

            double cakePrice = budget * 0.1;

            if (guest >=10 && guest <=15 )
            {
                coverPerson *= 0.85;
            }
            else if (guest > 15 && guest <= 20)
            {
                coverPerson *= 0.8;
            }
            else if (guest > 20)
            {
                coverPerson *= 0.75;
            }

            double sum = guest * coverPerson + cakePrice;

            if (budget >= sum)
            {
                double moneyLeft = budget - sum;
                Console.WriteLine($"It is party time! {moneyLeft:f2} leva left.");
            }
            else 
            {
                double moneyNeeded = sum - budget;
                Console.WriteLine($"No party! {moneyNeeded:f2} leva needed.");
            }
        }
    }
}
