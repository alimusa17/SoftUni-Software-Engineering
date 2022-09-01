using System;

namespace _08._Fuel_Tank_Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfFuel = Console.ReadLine();
            double litersOfFuel = double.Parse(Console.ReadLine());
            string discount = Console.ReadLine();
            double price = 0;

            if (typeOfFuel == "Gasoline")
            {
                price = litersOfFuel * 2.22;

                if (discount == "Yes")
                {
                    price = litersOfFuel * (2.22 - 0.18);
                }

                else if (litersOfFuel >= 20 && litersOfFuel <= 25)
                {
                    price = price * 0.92;           //discount 8%
                }

                else if (litersOfFuel > 25)
                {
                    price = price * 0.9;            //discount 10%
                }

            }

            else if (typeOfFuel == "Diesel")
            {
                price = litersOfFuel * 2.33;

                if (discount == "Yes")
                {
                    price = litersOfFuel * (2.33 - 0.12);

                    if (litersOfFuel >= 20 && litersOfFuel <= 25)
                    {
                        price = price * 0.92;           //discount 8%
                    }

                    else if (litersOfFuel > 25)
                    {
                        price = price * 0.9;            //discount 10%
                    }
                }
            }

            else
            {
                price = litersOfFuel * 0.93;

                if (discount == "Yes")
                {
                    price = litersOfFuel * (0.93 - 0.08);

                    if (litersOfFuel >= 20 && litersOfFuel <= 25)
                    {
                        price = price * 0.92;           //discount 8%
                    }

                    else if (litersOfFuel > 25)
                    {
                        price = price * 0.9;            //discount 10%
                    }
                }
            }

            Console.WriteLine($"{price:F2} lv.");
        }
    }
}