using System;

namespace _05._Excursion_Sale
{
    class Program
    {
        static void Main(string[] args)
        {
            int seaCount = int.Parse(Console.ReadLine());
            int moutainCount = int.Parse(Console.ReadLine());

            int seaPrice = 680;
            int mountainPrice = 499;

            double profit = 0;

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Stop")
                {
                    Console.WriteLine("Good job! Everything is sold.");
                    break;
                }
                if (input == "sea" && seaCount != 0)
                {
                    profit += seaPrice;
                    seaCount--;
                }
                else if (input == "mountain" && moutainCount != 0)
                {
                    profit += mountainPrice;
                    moutainCount--;
                }

                if (seaCount == 0)
                    if (moutainCount == 0)
                        break;

                if (moutainCount == 0)
                    if (seaCount == 0)
                        break;
            }

            Console.WriteLine($"Profit: {profit:f2} leva.");
        }
    }
}
