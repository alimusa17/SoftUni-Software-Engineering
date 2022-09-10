using System;

namespace _04._Club
{
    class Program
    {
        static void Main(string[] args)
        {
            double target = double.Parse(Console.ReadLine()); //желана печалба
            string cocktails = Console.ReadLine();           // име на коктейла string 
            double income = 0;                              // (приходи) предварително създаваме

            while (cocktails != "Party!")
            {
                int quantity = int.Parse(Console.ReadLine());   //к-во = по УСЛОВИЕ ОТ КОНЗОЛАТА 6 бр. коктейли

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

                cocktails = Console.ReadLine();                     //проверява дали името е Party!
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

