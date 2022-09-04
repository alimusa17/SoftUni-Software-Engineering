using System;

namespace _1._EasterLunch
{
    class Program
    {
        static void Main(string[] args)
        {
            double easterBread = double.Parse(Console.ReadLine());
            double eggs = double.Parse(Console.ReadLine());
            double cookies = double.Parse(Console.ReadLine());
            double eggsPaint = 0.15;
            double eggsInBox = 12;

            double easterBreadPrice = easterBread * 3.2;
            double eggsPrice = eggs * 4.35;
            double cookiesPrice = cookies * 5.4;
            double paintForEggs = eggs * eggsInBox * eggsPaint;

            double sum = easterBreadPrice + eggsPrice + cookiesPrice + paintForEggs;

            Console.WriteLine($"{sum:f2}");

        }
    }
}
