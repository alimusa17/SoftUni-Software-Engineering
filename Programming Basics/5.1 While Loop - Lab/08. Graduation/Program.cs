using System;

namespace _08._Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            int grade = 1;
            double sum = 0;
            int counter = 0;

            while (grade <= 12)
            {
                double yearlyGrade = double.Parse(Console.ReadLine());

                if (yearlyGrade < 4)
                {
                    if (counter == 1)
                    {
                        break;
                    }
                    counter++;
                    continue;
                }

                sum += yearlyGrade;
                grade++;
            }

            double averageGrade = sum / 12;

            if (grade > 12)
            {
                Console.WriteLine($"{name} graduated. Average grade:{averageGrade:f2}");
            }
            else
            {
                Console.WriteLine($"{name} has been excluded at {grade} grade");
            }
           
           

        }
    }
}
