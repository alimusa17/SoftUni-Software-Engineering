using System;

namespace _07._Hotel_Room
{
    class Program
    {
        static void Main(string[] args)
        {
            string mounth = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            double studioPrice = 0;
            double apartmentPrice = 0;

            if (mounth == "May" || mounth == "October")
            {
                studioPrice = nights * 50;
                apartmentPrice = nights * 65;
                if (nights > 14)
                {
                    apartmentPrice -= apartmentPrice * 0.10;
                    studioPrice -= studioPrice * 0.30;
                }
                else if (nights > 7)
                {
                    studioPrice -= studioPrice * 0.05;
                }
            }
            else if (mounth == "June" || mounth == "September")
            {
                studioPrice = nights * 75.20;
                apartmentPrice = nights * 68.70;
                if (nights > 14)
                {
                    apartmentPrice -= apartmentPrice * 0.10;
                    studioPrice -= studioPrice * 0.20;
                }
            }
            else
            {
                studioPrice = nights * 76;
                apartmentPrice = nights * 77;
                if (nights > 14)
                {
                    apartmentPrice -= apartmentPrice * 0.10;
                }
            }

            Console.WriteLine($"Apartment: {apartmentPrice:f2} lv.");
            Console.WriteLine($"Studio: {studioPrice:f2} lv.");

        }
    }
}
