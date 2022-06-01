using System;

namespace _08._Basketball_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double taxPerYear = double.Parse(Console.ReadLine());

            double shouesPrice = taxPerYear - taxPerYear * (40 / 100.0);
            double outfitPrice = shouesPrice - shouesPrice * (20 / 100.0);
            double ballPrice = outfitPrice / 4;
            double accPrice = ballPrice / 5;

            double sum = taxPerYear + shouesPrice + outfitPrice + ballPrice + accPrice;

            Console.WriteLine(sum);
        }
    }
}
