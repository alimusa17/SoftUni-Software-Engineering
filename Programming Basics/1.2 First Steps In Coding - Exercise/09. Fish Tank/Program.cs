using System;

namespace _09._Fish_Tank
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            double percent = double.Parse(Console.ReadLine());

            double volume = lenght * width * height;

            double volumeInLiters = volume / 1000;

            double busy = percent / 100;

            double liters = volumeInLiters * (1 - busy);

            Console.WriteLine(liters);

        }
    }
}
