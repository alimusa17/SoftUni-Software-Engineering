using System;

namespace _04._Transport_Price
{
    class Program
    {
        static void Main(string[] args)
        {
            int distance = int.Parse(Console.ReadLine());
            string dayOrNight = Console.ReadLine();

            double price = 0;

            double taxiRate = 0;

            if (dayOrNight == "day")
            {
                taxiRate = 0.79;
            }
            else
            {
                taxiRate = 0.9;
            }

            if (distance < 20)
            {
                price = 0.7 + distance * taxiRate;
            }
            else if (distance < 100)
            {
                price = distance * 0.09;
            }
            else
            {
                price = distance * 0.06;
            }

            Console.WriteLine($"{price:F2}");
        }
    }
}

