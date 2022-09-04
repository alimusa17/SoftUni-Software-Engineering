using System;

namespace _01._Fruits_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            double strawberriesPrice = double.Parse(Console.ReadLine());
            double raspberriesPrice = strawberriesPrice / 2;

            double bananas = double.Parse(Console.ReadLine());
            double oranges = double.Parse(Console.ReadLine());
            double raspberries = double.Parse(Console.ReadLine());
            double strawberries = double.Parse(Console.ReadLine());

            bananas = bananas * raspberriesPrice * 20 / 100;
            oranges = oranges * raspberriesPrice * 60 / 100;
            raspberries = raspberries * raspberriesPrice;
            strawberries = strawberries * strawberriesPrice;

            Console.WriteLine($"{bananas + oranges + raspberries + strawberries:f2}");
        }
    }
}
