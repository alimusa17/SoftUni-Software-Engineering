using System;

namespace _01._Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string ticketType = Console.ReadLine();
            int row = int.Parse(Console.ReadLine());
            int col = int.Parse(Console.ReadLine());

            double income = row * col;

            if (ticketType == "Premiere")
            {
                income = income * 12.00;
            }
            else if (ticketType == "Normal")
            {
                income = income * 7.50;
            }
            else
            {
                income = income * 5.00;
            }

            Console.WriteLine($"{income:f2} leva");

        }
    }
}
