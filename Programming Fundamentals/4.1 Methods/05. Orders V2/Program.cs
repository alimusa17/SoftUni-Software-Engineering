using System;

namespace _05._Orders_V2
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintPrice(Console.ReadLine(), int.Parse(Console.ReadLine()));
        }

        static void PrintPrice(string product, int quantity)
        {
            switch (product)
            {
                case "coffee":
                    Console.WriteLine($"{quantity * 1.5:f2}");
                    break;
                case "water":
                    Console.WriteLine($"{quantity:f2}");
                    break;
                case "coke":
                    Console.WriteLine($"{quantity * 1.4:f2}");
                    break;
                case "snacks":
                    Console.WriteLine($"{quantity * 2:f2}");
                    break;
            }
        }
    }
}
