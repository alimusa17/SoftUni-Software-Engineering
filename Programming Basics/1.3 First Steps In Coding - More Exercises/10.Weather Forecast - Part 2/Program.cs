using System;

namespace _10.Weather_Forecast___Part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double degree = double.Parse(Console.ReadLine());

            if (degree >= 26.00 && degree <= 35.00)
            {
                Console.WriteLine("Hot");
            }
            else if (degree >= 20.01 && degree <= 25.9)
            {
                Console.WriteLine("Warm");
            }
            else if (degree >= 15.00 && degree <= 20.00)
            {
                Console.WriteLine("Mild");
            }
            else if (degree >= 12.00 && degree <= 14.9)
            {
                Console.WriteLine("Cool");
            }
            else if (degree >= 5.0 && degree <= 11.9)
            {
                Console.WriteLine("Cold");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
