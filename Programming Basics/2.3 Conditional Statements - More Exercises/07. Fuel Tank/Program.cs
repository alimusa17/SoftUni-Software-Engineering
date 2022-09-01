using System;

namespace _07._Fuel_Tank
{
    class Program
    {
        static void Main(string[] args)
        {
            string fuel = Console.ReadLine();
            int liters = int.Parse(Console.ReadLine());

            if (fuel == "Diesel" || fuel == "Gasoline" || fuel == "Gas")
            {
                if (liters >= 25)
                {
                    string lowercase = fuel.ToLower();
                    Console.WriteLine($"You have enough {lowercase}.");
                }
                else
                {
                    string lowercase = fuel.ToLower();
                    Console.WriteLine($"Fill your tank with {lowercase}!");
                }
            }
            else
            {
                Console.WriteLine("Invalid fuel!");
            }
        }
    }
}
