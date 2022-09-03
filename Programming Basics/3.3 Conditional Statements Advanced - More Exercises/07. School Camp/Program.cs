using System;

namespace _07._School_Camp
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            string group = Console.ReadLine();
            int numberOfStudents = int.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());

            double price = 0.0;
            string typeSport = " ";
            double totalPrice = 0.0;

            if (season == "Winter")
            {
                if (group == "boys")
                {
                    typeSport = "Judo";
                    price = 9.6;
                }
                else if (group == "girls")
                {
                    typeSport = "Gymnastics";
                    price = 9.6;
                }
                else
                {
                    typeSport = "Ski";
                    price = 10;
                }
            }
            else if (season == "Spring")
            {
                if (group == "boys")
                {
                    typeSport = "Tennis";
                    price = 7.2;
                }
                else if (group == "girls")
                {
                    typeSport = "Athletics";
                    price = 7.2;
                }
                else
                {
                    typeSport = "Cycling";
                    price = 9.5;
                }
            }
            else
            {
                if (group == "boys")
                {
                    typeSport = "Football";
                    price = 15;
                }
                else if (group == "girls")
                {
                    typeSport = "Volleyball";
                    price = 15;
                }
                else
                {
                    typeSport = "Swimming";
                    price = 20;
                }
            }

            double nightsPrice = numberOfStudents * price * nights;

            if (numberOfStudents >= 50)
            {
                totalPrice = nightsPrice * 0.5;
            }
            else if (numberOfStudents >= 20 && numberOfStudents < 50)
            {
                totalPrice = nightsPrice * 0.85;
            }
            else if (numberOfStudents >= 10 && numberOfStudents < 20)
            {
                totalPrice = nightsPrice * 0.95;
            }
            else
            {
                totalPrice = nightsPrice;
            }

            Console.WriteLine($"{typeSport} {totalPrice:F2} lv.");
        }
    }
}

