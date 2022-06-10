using System;

namespace _09._Ski_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            int nights = int.Parse(Console.ReadLine());
            nights = nights - 1;
            string roomType = Console.ReadLine();
            string feedback = Console.ReadLine();

            double result = 0;

            switch (roomType)
            {
                case "room for one person":
                    result = nights * 18;
                    break;
                case "apartment":
                    result = nights * 25;
                    if (nights < 10)
                    {
                        result *= 0.7;
                    }
                    else if (nights <= 15)
                    {
                        result *= 0.65;
                    }
                    else
                    {
                        result *= 0.5;
                    }
                    break;
                case "president apartment":
                    result = nights * 35;
                    if (nights < 10)
                    {
                        result *= 0.9;
                    }
                    else if (nights <= 15)
                    {
                        result *= 0.85;
                    }
                    else
                    {
                        result *= 0.80;
                    }
                    break;
                
            }

            if (feedback == "positive")
            {
                result *= 1.25;                     
            }
            else if (feedback == "negative")
            {
                result *= 0.9;                    
            }

            Console.WriteLine($"{result:f2}");
        }
    }
}
