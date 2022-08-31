using System;

namespace _03._Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            int m2Grapes = int.Parse(Console.ReadLine());
            double grapesFor1m2 = double.Parse(Console.ReadLine());
            int neededLitersWine = int.Parse(Console.ReadLine());
            int numOfWorkers = int.Parse(Console.ReadLine());


            double totalGrapes = m2Grapes * grapesFor1m2;
            double wine = 0.4 * totalGrapes / 2.5;

            if (neededLitersWine < wine)
            {
                double litersLeft = wine - neededLitersWine;
                double litersPerPerson = litersLeft / numOfWorkers;

                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(wine)} liters.");
                Console.WriteLine($"{Math.Ceiling(litersLeft)} liters left -> {Math.Ceiling(litersPerPerson)} liters per person.");
            }
            else
            {
                double moreLiters = Math.Abs(wine - neededLitersWine);

                Console.WriteLine($"It will be a tough winter! More {Math.Floor(moreLiters)} liters wine needed");
            }
        }
    }
}
