using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int peopleCount = int.Parse(Console.ReadLine());
            string groupeType = Console.ReadLine();
            string day = Console.ReadLine();
            double totalPrice = 0;

            if (groupeType == "Students")
            {
                if (day == "Friday")
                {
                    totalPrice = peopleCount * 8.45;
                }
                else if (day == "Saturday")
                {
                    totalPrice = peopleCount * 9.80;
                }
                else if (day == "Sunday")
                {
                    totalPrice = peopleCount * 10.46;
                }

                if (peopleCount >= 30)
                {
                    totalPrice -= totalPrice * 0.15;
                }
            }
            else if (groupeType == "Business")
            {
                if (day == "Friday")
                {
                    totalPrice = peopleCount * 10.90;
                }
                else if (day == "Saturday")
                {
                    totalPrice = peopleCount * 15.60;
                }
                else if (day == "Sunday")
                {
                    totalPrice = peopleCount * 16;
                }

                if (peopleCount >= 100)
                {
                    totalPrice -= totalPrice / peopleCount * 10;
                }
            }
            else if (groupeType == "Regular")
            {
                if (day == "Friday")
                {
                    totalPrice = peopleCount * 15;
                }
                else if (day == "Saturday")
                {
                    totalPrice = peopleCount * 20;
                }
                else if (day == "Sunday")
                {
                    totalPrice = peopleCount * 22.50;
                }

                if (peopleCount >= 10 && peopleCount <= 20)
                {
                    totalPrice -= totalPrice * 0.05;
                }
            }

            Console.WriteLine($"Total price: {totalPrice:f2}");

        }
    }
}
