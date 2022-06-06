using System;

namespace _07.Working_Hours
{
    class Program
    {
        static void Main(string[] args)
        {
            int Hours = int.Parse(Console.ReadLine());

            string DayOfWeek = Console.ReadLine();

            if (Hours >= 10 && Hours <= 18 && DayOfWeek != "Sunday")
            {
                Console.WriteLine("open");
            }
            else
            {
                Console.WriteLine("closed");
            }
        }
    }
}
