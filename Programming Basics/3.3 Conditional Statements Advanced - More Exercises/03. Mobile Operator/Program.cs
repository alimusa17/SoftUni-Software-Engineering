using System;

namespace _03._Mobile_Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            string contract = Console.ReadLine();
            string typeContract = Console.ReadLine();
            string typeMobileInternet = Console.ReadLine();
            int mounths = int.Parse(Console.ReadLine());

            double price = 0;

            if (typeContract == "Small")
            {
                if (contract == "one")
                {
                    price = 9.98;
                }
                else if (contract == "two")
                {
                    price = 8.58;
                }
            }
            else if (typeContract == "Middle")
            {
                if (contract == "one")
                {
                    price = 18.99;
                }
                else if (contract == "two")
                {
                    price = 17.09;
                }
            }
            else if (typeContract == "Large")
            {
                if (contract == "one")
                {
                    price = 25.98;
                }
                else if (contract == "two")
                {
                    price = 23.59;
                }
            }
            else if (typeContract == "ExtraLarge")
            {
                if (contract == "one")
                {
                    price = 35.99;
                }
                else if (contract == "two")
                {
                    price = 31.79;
                }
            }

            if (typeMobileInternet == "yes")
            {
                if (price <= 10)
                {
                    price += 5.5;
                }
                else if (price < 30)
                {
                    price += 4.35;
                }
                else
                {
                    price += 3.85;
                }
            }

            double totalPrice = price * mounths;

            if (contract == "two")
            {
                totalPrice *= (1 - 0.0375);
            }

            Console.WriteLine($"{totalPrice:f2} lv.");
        }
    }
}
