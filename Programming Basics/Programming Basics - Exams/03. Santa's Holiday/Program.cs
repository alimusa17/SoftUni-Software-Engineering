using System;

namespace _03.Santa_s_Holiday
{
    class Program
    {
        static void Main(string[] args)
        {
            int nights = int.Parse(Console.ReadLine());
            nights = nights - 1;

            string roomType = Console.ReadLine();
            string feedback = Console.ReadLine();

            double sum = 0;

            switch (roomType)
            {
                case "room for one person":
                    sum = nights * 18;
                    break;
                case "apartment":
                    sum = nights * 25;
                    if (nights < 10)
                    {
                        sum *= 0.7;
                    }
                    else if (nights <= 15)
                    {
                        sum *= 0.65;
                    }
                    else
                    {
                        sum *= 0.5;
                    }
                    break;
                case "president apartment":
                    sum = nights * 35;
                    if (nights < 10)
                    {
                        sum *= 0.9;
                    }
                    else if (nights <= 15)
                    {
                        sum *= 0.85;
                    }
                    else
                    {
                        sum *= 0.8;
                    }
                    break;
            }
            if (feedback == "positive")
            {
                sum *= 1.25;
            }
            else if (feedback == "negative")
            {
                sum *= 0.9;
            }

            Console.WriteLine($"{sum:f2}");
        }
    }
}
