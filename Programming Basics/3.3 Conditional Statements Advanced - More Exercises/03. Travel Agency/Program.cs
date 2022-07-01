using System;

namespace _03._Travel_Agency
{
    class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            string pack = Console.ReadLine();
            bool hasVIP = Console.ReadLine() == "yes"; 
            int days = int.Parse(Console.ReadLine());
            bool isValid = false;

            double price = 0;

            if (days > 7)           
            {
                days--;
            }

            switch (town)
            {
                case "Bansko":
                case "Borovets":
                    if (hasVIP)   
                    {
                        if (pack == "noEquipment")
                        {
                            price = 80 * 0.95;       
                        }
                        else if (pack == "withEquipment")
                        {
                            price = 100 * 0.9;   
                        }
                        else
                        {
                            isValid = true;
                        }
                    }
                    else
                    {
                        if (pack == "noEquipment")
                        {
                            price = 80;
                        }
                        else if (pack == "withEquipment")
                        {
                            price = 100;
                        }
                        else
                        {
                            isValid = true;
                        }
                    }
                    break;

                case "Varna":
                case "Burgas":
                    if (hasVIP)
                    {
                        if (pack == "noBreakfast")
                        {
                            price = 100 * 0.93;
                        }
                        else if (pack == "withBreakfast")
                        {
                            price = 130 * 0.88;
                        }
                        else
                        {
                            isValid = true;
                        }
                    }
                    else
                    {
                        if (pack == "noBreakfast")
                        {
                            price = 100;
                        }
                        else if (pack == "withBreakfast")
                        {
                            price = 130;
                        }
                        else
                        {
                            isValid = true;
                        }
                    }
                    break;
                default:
                    isValid = true;
                    break;
            }
            if (isValid)
            {
                Console.WriteLine("Invalid input!");
            }
            else if (days < 1)
            {
                Console.WriteLine("Days must be a positive number!");
            }
            else
            {
                double finalPrice = days * price;
                Console.WriteLine($"The price is {finalPrice:f2}lv.! Have a nice time!");
            }

        }
    }
}
