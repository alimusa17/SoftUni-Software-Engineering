using System;

namespace _11._HappyCat_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            double days = double.Parse(Console.ReadLine());
            double hours = double.Parse(Console.ReadLine());

            double sumForDay = 0;
            double totalSum = 0;

            for (int i = 1; i <= days; i++)
            {
                sumForDay = 0;

                for (int k = 1; k <= hours; k++)
                {
                    if (i % 2 == 0 && k % 2 != 0)
                    {
                        sumForDay += 2.50;
                    }
                    else if (i % 2 != 0 && k % 2 == 0)
                    {
                        sumForDay += 1.25;
                    }
                    else
                    {
                        sumForDay += 1;
                    }
                }

                totalSum += sumForDay;
                Console.WriteLine($"Day: {i} - {sumForDay:F2} leva");
            }
            Console.WriteLine($"Total: {totalSum:F2} leva");
        }
    }
}
