using System;

namespace _03.Celsius_to_Fahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            double celsius = double.Parse(Console.ReadLine());
            double fahrenheit = (celsius * 1.8) + 32;

            Console.WriteLine($"{fahrenheit:f2}");
        }
    }
}
