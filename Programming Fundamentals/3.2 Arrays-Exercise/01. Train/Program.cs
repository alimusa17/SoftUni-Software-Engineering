using System;

namespace _01._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOdWagons = int.Parse(Console.ReadLine());
            int[] wagons = new int[numberOdWagons];

            int sum = 0;

            for (int indexOfWagons = 0; indexOfWagons < wagons.Length; indexOfWagons++)
            {
                wagons[indexOfWagons] = int.Parse(Console.ReadLine());
                sum += wagons[indexOfWagons];
            }

            foreach (int wagon in wagons)
            {
                Console.Write($"{wagon} ");
            }

            Console.Write(sum);
        }
    }
}
