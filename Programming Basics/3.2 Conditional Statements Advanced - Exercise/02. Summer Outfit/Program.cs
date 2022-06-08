using System;

namespace _02._Summer_Outfit
{
    class Program
    {
        static void Main(string[] args)
        {
            double degrees = double.Parse(Console.ReadLine());
            string time = Console.ReadLine();

            string outfit = "Shirt";
            string shoes = "Moccasins";

            if (time == "Morning")
            {
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
            }
            else if (time == "Afternoon")
            {
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
