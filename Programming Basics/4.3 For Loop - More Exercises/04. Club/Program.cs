using System;

namespace _04._Club
{
    class Program
    {
        static void Main(string[] args)
        {
            double target = double.Parse(Console.ReadLine());  
            string cocktails = Console.ReadLine();             
            double income = 0;                                 

            while (cocktails != "Party!")
            {
                int quantity = int.Parse(Console.ReadLine());   

                int price = quantity * cocktails.Length; 
                double finalPrice = price;

                if (price % 2 != 0)
                {
                    finalPrice *= 0.75;
                }
                income += finalPrice;
                target -= finalPrice;

                if (target <= 0)
                {
                    break;
                }

                cocktails = Console.ReadLine();                     
            }

            if (cocktails == "Party!")
            {
                Console.WriteLine($"We need {target:F2} leva more.");
            }
            else
            {
                Console.WriteLine("Target acquired.");
            }

            Console.WriteLine($"Club income - {income:F2} leva.");
        }
    }
}

