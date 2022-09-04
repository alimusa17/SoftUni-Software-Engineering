using System;

namespace _01._Movie_Profit
{
    class Program
    {
        static void Main(string[] args)
        {
            string movie = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());
            int tickets = int.Parse(Console.ReadLine());
            double ticketPrice = double.Parse(Console.ReadLine());
            int percent = int.Parse(Console.ReadLine());

            double ticketForDay = tickets * ticketPrice;

            double profit = days * ticketForDay;

            double percentProfit = profit * percent / 100;

            double movieProfit = profit - percentProfit;

            Console.WriteLine($"The profit from the movie {movie} is {movieProfit:f2} lv.");
        }
    }
}
