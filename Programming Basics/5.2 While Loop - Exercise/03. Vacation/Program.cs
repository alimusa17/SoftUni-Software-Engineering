using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double neededMoney = double.Parse(Console.ReadLine());
            double availableMoney = double.Parse(Console.ReadLine());

            int count = 0;
            int spendCount = 0;

            string input = "";
            double money = 0;

            while (availableMoney < neededMoney)
            {
                input = Console.ReadLine();
                money = double.Parse(Console.ReadLine());

                count++;
                if (input == "spend")
                {
                    spendCount++;
                    availableMoney -= money;

                    if (availableMoney < 0)
                    {
                        availableMoney = 0;
                    }
                    if (spendCount == 5)
                    {
                        break;
                    }
                }
                else
                {
                    availableMoney += money;
                    spendCount = 0;
                }
            }
            if (spendCount == 5)
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine(count);
            }
            else
            {
                Console.WriteLine($"You saved the money for {count} days.");
            }
        }
    }
}
