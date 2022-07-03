using System;

namespace _01._Moon
{
    class Program
    {
        static void Main(string[] args)
        {
            double avSpeed = double.Parse(Console.ReadLine());
            double litersPerHundred = double.Parse(Console.ReadLine());

            double totalDistance = 384400 * 2;
            double roundTrip = totalDistance / avSpeed;

            double totalTime = Math.Ceiling(roundTrip) + 3;
            double fuelLiters = totalDistance * litersPerHundred / 100;

            Console.WriteLine($"{Math.Ceiling(totalTime)}");
            Console.WriteLine($"{fuelLiters}");
        }
    }
}
