using System;

namespace _02_Deer_of_Santa
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysWithoutSanta = int.Parse(Console.ReadLine());
            int foodQuantity = int.Parse(Console.ReadLine());        

            double deer1Food = double.Parse(Console.ReadLine());
            double deer2Food = double.Parse(Console.ReadLine());
            double deer3Food = double.Parse(Console.ReadLine());

            double totalFood = (deer1Food + deer2Food + deer3Food) * daysWithoutSanta;

            double leftFood = Math.Floor(foodQuantity - totalFood);
            double neededFood = Math.Ceiling(totalFood - foodQuantity);

            if (totalFood < leftFood)
            {
                Console.WriteLine($"{leftFood} kilos of food left.");
            }
            else
            {
                Console.WriteLine($"{neededFood} more kilos of food are needed.");
            }
        }
    }
}
