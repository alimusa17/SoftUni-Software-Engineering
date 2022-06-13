using System;

namespace _04._Clever_Lily
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());

            double washingMachine = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());

            double money = 0;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    money += i * 5 - 1;
                }
                else
                {
                    money += toyPrice;
                }
            }

            if (money >= washingMachine)
            {
                Console.WriteLine($"Yes! {money-washingMachine:f2}");
            }
            else
            {
                Console.WriteLine($"No! {washingMachine - money:f2}");
            }
        }
    }
}
