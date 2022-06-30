using System;

namespace _03._Excursion_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int persons = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            double pricePerson = 0;

            if (season == "spring")
            {
                if (persons <= 5)
                {
                    pricePerson = 50;
                }
                else if (persons > 5)
                {
                    pricePerson = 48;
                }
            }
            else if (season == "summer")
            {
                if (persons <= 5)
                {
                    pricePerson = 48.50;
                }
                else if (persons > 5)
                {
                    pricePerson = 45;
                }
                pricePerson *= 0.85;            
            }
            else if (season == "autumn")
            {
                if (persons <= 5)
                {
                    pricePerson = 60;
                }
                else if (persons > 5)
                {
                    pricePerson = 49.5;
                }
            }
            else if (season == "winter")
            {
                if (persons <= 5)
                {
                    pricePerson = 86;
                }
                else if (persons > 5)
                {
                    pricePerson = 85;
                }
                pricePerson *= 1.08;            
            }

            double totalSum = persons * pricePerson;

            Console.WriteLine($"{totalSum:f2} leva.");
        }
    }
}
