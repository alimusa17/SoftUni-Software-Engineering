using System;

namespace _06._Truck_Driver
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            double kilometersPerMonth = double.Parse(Console.ReadLine());

            double price = 0.0;

            if (season == "Summer")
            {
                if (kilometersPerMonth <= 5000)
                {
                    price = 0.9;
                }
                else if (kilometersPerMonth > 5000 && kilometersPerMonth <= 10000)
                {
                    price = 1.1;
                }
                else if (kilometersPerMonth > 10000 && kilometersPerMonth <= 20000)
                {
                    price = 1.45;
                }
            }
            else if (season == "Winter")
            {
                if (kilometersPerMonth <= 5000)
                {
                    price = 1.05;
                }
                else if (kilometersPerMonth > 5000 && kilometersPerMonth <= 10000)
                {
                    price = 1.25;
                }
                else if (kilometersPerMonth > 10000 && kilometersPerMonth <= 20000)
                {
                    price = 1.45;
                }
            }
            else
            {
                if (kilometersPerMonth <= 5000)
                {
                    price = 0.75;
                }
                else if (kilometersPerMonth > 5000 && kilometersPerMonth <= 10000)
                {
                    price = 0.95;
                }
                else if (kilometersPerMonth > 10000 && kilometersPerMonth <= 20000)
                {
                    price = 1.45;
                }
            }

            double totalPrice = kilometersPerMonth * price * 4;
            double salary = totalPrice * 0.9;

            Console.WriteLine($"{salary:F2}");
        }
    }
}

