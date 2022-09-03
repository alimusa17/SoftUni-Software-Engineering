using System;

namespace _02._Bike_Race
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberJuniors = int.Parse(Console.ReadLine());
            int numberSeniors = int.Parse(Console.ReadLine());
            string trackType = Console.ReadLine();

            int totalPeople = numberJuniors + numberSeniors;

            if (trackType == "trail")
            {
                double sum = (numberJuniors * 5.5 + numberSeniors * 7) * 0.95;              //sum - 5%

                Console.WriteLine($"{sum:F2}");
            }
            else if (trackType == "cross-country")
            {
                if (totalPeople < 50)
                {
                    double sum = (numberJuniors * 8 + numberSeniors * 9.5) * 0.95;          //sum - 5%

                    Console.WriteLine($"{sum:F2}");
                }
                else
                {
                    double sum = ((numberJuniors * 8 + numberSeniors * 9.5) * 0.95) * 0.75; //(sum - 5%) - 75%

                    Console.WriteLine($"{sum:F2}");
                }
            }
            else if (trackType == "downhill")
            {
                double sum = (numberJuniors * 12.25 + numberSeniors * 13.75) * 0.95;        //sum - 5%

                Console.WriteLine($"{sum:F2}");
            }
            else if (trackType == "road")
            {
                double sum = (numberJuniors * 20 + numberSeniors * 21.5) * 0.95;            //sum - 5%

                Console.WriteLine($"{sum:F2}");
            }
        }
    }
}
