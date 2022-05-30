using System;

namespace _08._Pet_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            int dogfoodCount = int.Parse(Console.ReadLine());
            int catfoodCount = int.Parse(Console.ReadLine());

            double dogfoodPrice = dogfoodCount * 2.5; 
            double catfoodPrice = catfoodCount * 4; 

            double sum = dogfoodPrice + catfoodPrice;

            Console.WriteLine($"{sum} lv.");

        }
    }
}
