using System;

namespace _03._Deposit_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double depositSum = double.Parse(Console.ReadLine());
            int months = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            double interest = depositSum * (percent / 100);
            double interestPermonth = interest / 12;

            double sum = depositSum + months * interestPermonth;

            Console.WriteLine(sum);
        }
    }
}
