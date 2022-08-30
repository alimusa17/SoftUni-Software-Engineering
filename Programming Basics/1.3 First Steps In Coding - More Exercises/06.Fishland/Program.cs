using System;

namespace _06.Fishland
{
    class Program
    {
        static void Main(string[] args)
        {
            double mackelerPriceKg = double.Parse(Console.ReadLine());      
            double sprinklePriceKg = double.Parse(Console.ReadLine());      
            double bonitoKg = double.Parse(Console.ReadLine());             
            double safridKg = double.Parse(Console.ReadLine());
            double musselsKg = double.Parse(Console.ReadLine());            

            double bonitoPriceKg = mackelerPriceKg + mackelerPriceKg * 0.6;
            double bonitoTotalPrice = bonitoKg * bonitoPriceKg;

            double safridPrice = sprinklePriceKg + sprinklePriceKg * 0.8;
            double safridTotalPrice = safridKg * safridPrice;

            double musselsTotalPrice = musselsKg * 7.5;

            double totalSum = bonitoTotalPrice + safridTotalPrice + musselsTotalPrice;

            Console.WriteLine($"{totalSum:F2}");
        }
    }
}
