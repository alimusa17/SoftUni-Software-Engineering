using System;

namespace _03._Football_Souvenirs
{
    class Program
    {
        static void Main(string[] args)
        {
            string teamName = Console.ReadLine();
            string typeSouvenir = Console.ReadLine();
            int souvenirsCount = int.Parse(Console.ReadLine());

            double price = 0;

            if (typeSouvenir != "flags" && typeSouvenir != "caps" && typeSouvenir != "posters" && typeSouvenir != "stickers")
            {
                Console.WriteLine("Invalid stock!");
                return;
            }
            if (teamName == "Argentina")
            {
                if (typeSouvenir == "flags")
                {
                    price = 3.25;
                }
                else if (typeSouvenir == "caps")
                {
                    price = 7.2;
                }
                else if (typeSouvenir == "posters")
                {
                    price = 5.1;
                }
                else if (typeSouvenir == "stickers")
                {
                    price = 1.25;
                }
            }
            else if (teamName == "Brazil")
            {
                if (typeSouvenir == "flags")
                {
                    price = 4.2;
                }
                else if (typeSouvenir == "caps")
                {
                    price = 8.5;
                }
                else if (typeSouvenir == "posters")
                {
                    price = 5.35;
                }
                else if (typeSouvenir == "stickers")
                {
                    price = 1.2;
                }
            }
            else if (teamName == "Croatia")
            {
                if (typeSouvenir == "flags")
                {
                    price = 2.75;
                }
                else if (typeSouvenir == "caps")
                {
                    price = 6.9;
                }
                else if (typeSouvenir == "posters")
                {
                    price = 4.95;
                }
                else if (typeSouvenir == "stickers")
                {
                    price = 1.1;
                }
            }
            else if (teamName == "Denmark")
            {
                if (typeSouvenir == "flags")
                {
                    price = 3.1;
                }
                else if (typeSouvenir == "caps")
                {
                    price = 6.5;
                }
                else if (typeSouvenir == "posters")
                {
                    price = 4.8;
                }
                else if (typeSouvenir == "stickers")
                {
                    price = 0.9;
                }
            }
            else if (teamName != "Argentina" && teamName != "Brazil" && teamName != "Croatia" && teamName != "Denmark")
            {
                Console.WriteLine("Invalid country!");
                return;
            }

            Console.WriteLine($"Pepi bought {souvenirsCount} {typeSouvenir} of {teamName} for {price*souvenirsCount:f2} lv.");

        }
    }
}
