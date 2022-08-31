using System;

namespace _05._Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int foodLeft = int.Parse(Console.ReadLine());
            double foodForDog = double.Parse(Console.ReadLine());
            double foodForCat = double.Parse(Console.ReadLine());
            double foodForTurtle = double.Parse(Console.ReadLine());

            double foodTurtleKg = foodForTurtle / 1000;

            double foodNeededDog = days * foodForDog;
            double foodNeededCat = days * foodForCat;
            double foodNeededTurtle = days * foodTurtleKg;

            double totalFood = foodNeededDog + foodNeededCat + foodNeededTurtle;

            double foodRemains = foodLeft - totalFood;

            if (foodRemains > 0)
            {
                Console.WriteLine($"{Math.Floor(foodRemains)} kilos of food left.");
            }
            else
            {
                double foodNeeded = totalFood - foodLeft;

                Console.WriteLine($"{Math.Ceiling(foodNeeded)} more kilos of food are needed.");
            }
        }
    }
}
