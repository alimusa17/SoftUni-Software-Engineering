using System;

namespace _02._Summer_Outfit_Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            double degrees = double.Parse(Console.ReadLine());
            string time = Console.ReadLine();

            string outfit = "Shirt";
            string shoes = "Moccasins";

            switch (time)
            {
                case "Morning":
                    if (degrees <= 18)
                    {
                        outfit = "Sweatshirt";
                        shoes = "Sneakers";
                    }
                    else if (degrees <= 24)
                    {
                        outfit = "Shirt";
                        shoes = "Moccasins";
                    }
                    else
                    {
                        outfit = "T-Shirt";
                        shoes = "Sandals";
                    }
                    break;
                case "Afternoon":
                    if (degrees <= 18)
                    {
                        outfit = "Shirt";
                        shoes = "Moccasins";
                    }
                    else if (degrees <= 24)
                    {
                        outfit = "T-Shirt";
                        shoes = "Sandals";
                    }
                    else
                    {
                        outfit = "Swim Suit";
                        shoes = "Barefoot";
                    }
                    break;
            }
            //else if (time == "Evening")
            //    if (degrees <= 18)
            //    {
            //        outfit = "Shirt";
            //        shoes = "Moccasins";
            //    }
            //    else if (degrees <= 24)
            //    {
            //        outfit = "Shirt";
            //        shoes = "Moccasins";
            //    }
            //    else
            //    {
            //        outfit = "Shirt";
            //        shoes = "Moccasins";
            //    }

            Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");

        }
    }
}
