using System;

namespace _05._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string location = " ";
            string type = " ";

            if (budget <= 1000)
            {
                type = "Camp";
                if (season == "Summer")
                {
                    location = "Alaska";
                    budget = budget * 0.65;
                }
                else
                {
                    location = "Morocco";
                    budget = budget * 0.45;
                }
            }
            else if (budget > 1000 && budget <= 3000)
            {
                type = "Hut";
                if (season == "Summer")
                {
                    location = "Alaska";
                    budget = budget * 0.80;
                }
                else
                {
                    location = "Morocco";
                    budget = budget * 0.6;
                }
            }
            else
            {
                type = "Hotel";
                if (season == "Summer")
                {
                    location = "Alaska";
                    budget = budget * 0.9;
                }
                else
                {
                    location = "Morocco";
                    budget = budget * 0.9;
                }
            }

            Console.WriteLine($"{location} - {type} - {budget:F2}");
        }
    }
}

