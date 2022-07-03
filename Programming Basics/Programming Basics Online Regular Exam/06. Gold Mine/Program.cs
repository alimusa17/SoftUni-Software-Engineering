using System;

namespace _06._Gold_Mine
{
    class Program
    {
        static void Main(string[] args)
        {
            int locations = int.Parse(Console.ReadLine());

            for (int i = 0; i < locations; i++)
            {
                double avExtraction = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                double sumExtraction = 0;

                for (int j = 0; j < days; j++)
                {
                    double extraction = double.Parse(Console.ReadLine());
                    sumExtraction += extraction;
                }

                double average = sumExtraction / days;

                if (average >= avExtraction)
                {
                    Console.WriteLine($"Good job! Average gold per day: {average:f2}.");
                }
                else if (average < avExtraction)
                {
                    Console.WriteLine($"You need {avExtraction - average:f2} gold.");
                }

            }
        }
    }
}
