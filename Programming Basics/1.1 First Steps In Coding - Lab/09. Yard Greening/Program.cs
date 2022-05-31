using System;

namespace _09._Yard_Greening
{
    class Program
    {
        static void Main(string[] args)
        {
            double yard = double.Parse(Console.ReadLine());

            double yardCount = yard * 7.61;
            double discount = yardCount * 0.18;

            double sum = yardCount - discount;

            Console.WriteLine($"The final price is: {sum} lv.");
            Console.WriteLine($"The discount is: {discount} lv.");


        }
    }
}
