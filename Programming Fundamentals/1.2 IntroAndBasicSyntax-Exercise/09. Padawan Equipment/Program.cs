using System;

namespace _09._Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());
            double priceOfSaber = double.Parse(Console.ReadLine());
            double priceOfRobes = double.Parse(Console.ReadLine());
            double priceOfBelts = double.Parse(Console.ReadLine());

            double totalNumbersOfSabers = Math.Ceiling(studentsCount * 1.10);
            double numbersOfFreeBelts = Math.Floor(studentsCount / 6.0);

            double finalPriceOfSabers = totalNumbersOfSabers * priceOfSaber;
            double finalPriceOfRobes = studentsCount * priceOfRobes;
            double finalPriceForBelts = (studentsCount - numbersOfFreeBelts) * priceOfBelts;

            double totalFinalPrice = finalPriceOfSabers + finalPriceOfRobes + finalPriceForBelts;

            if (budget >= totalFinalPrice)
            {
                Console.WriteLine($"The money is enough - it would cost {totalFinalPrice:f2}lv.");
            }

            else
            {
                double neededMoney = Math.Abs(totalFinalPrice - budget);
                Console.WriteLine($"John will need {neededMoney:f2}lv more.");
            }
        }
    }
}
