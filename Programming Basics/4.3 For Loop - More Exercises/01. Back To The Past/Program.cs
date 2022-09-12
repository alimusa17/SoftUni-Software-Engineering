using System;

namespace _01._Back_To_The_Past
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int yearsLiveUpTo = int.Parse(Console.ReadLine());

            double totalMoney = 0;
            int ages = 18;

            for (int year = 1800; year <= yearsLiveUpTo; year++)
            {
                if (year % 2 == 0)
                {
                    totalMoney += 12000;
                }
                else
                {
                    totalMoney += 12000 + 50 * ages;
                }
                ages++;
            }

            if (money >= totalMoney)
            {
                Console.WriteLine($"Yes! He will live a carefree life and will have {(money - totalMoney):F2} dollars left.");
            }
            else
            {
                Console.WriteLine($"He will need {(totalMoney - money):F2} dollars to survive.");
            }
        }
    }
}
