using System;

namespace _03._Movie_Destination
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string destination = Console.ReadLine(); 
            string season = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());

            double shootingDay = 0;

            if (destination == "Sofia")
            {
                if (season == "Winter")
                {
                    shootingDay = days * 17000;
                }
                else
                {
                    shootingDay = days * 12500;
                }
                shootingDay *= 1.25;
            }
            else if (destination == "Dubai")
            {
                if (season == "Winter")
                {
                    shootingDay = days * 45000;
                }
                else
                {
                    shootingDay = days * 40000;
                }
                shootingDay *= 0.7;
            }
            else 
            {
                if (season == "Winter")
                {
                    shootingDay = days * 24000;
                }
                else
                {
                    shootingDay = days * 20250;
                }
            }
            if (budget > shootingDay)
            {
                Console.WriteLine($"The budget for the movie is enough! We have {budget-shootingDay:f2} leva left!");
            }
            else
            {
                Console.WriteLine($"The director needs {shootingDay-budget:f2} leva more!");
            }
        }
    }
}
