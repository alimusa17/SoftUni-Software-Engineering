using System;

namespace _04._Car_To_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string type = " ";
            string classOfCar = " ";

            if (budget <= 100)
            {
                classOfCar = "Economy class";
                if (season == "Summer")
                {
                    type = "Cabrio";
                    budget = budget * 0.35;
                }
                else
                {
                    type = "Jeep";
                    budget = budget * 0.65;
                }
            }
            else if (budget > 100 && budget <= 500)
            {
                classOfCar = "Compact class";
                if (season == "Summer")
                {
                    type = "Cabrio";
                    budget = budget * 0.45;
                }
                else
                {
                    type = "Jeep";
                    budget = budget * 0.80;
                }
            }
            else
            {
                classOfCar = "Luxury class";
                type = "Jeep";
                budget = budget * 0.90;
            }

            Console.WriteLine($"{classOfCar}");
            Console.WriteLine($"{type} - {budget:F2}");
        }
    }
}

