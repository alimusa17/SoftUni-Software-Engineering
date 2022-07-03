using System;

namespace _05._Puppy_Care
{
    class Program
    {
        static void Main(string[] args)
        {
            int kgFoods = int.Parse(Console.ReadLine());
            int ate = 0;

            string command = Console.ReadLine();

            while (command != "Adopted")
            {
                int grFoods = int.Parse(command);
                ate += grFoods;
                command = Console.ReadLine();
            }
             
            if (ate <= kgFoods * 1000)
            {
                int diff = kgFoods * 1000 - ate;
                Console.WriteLine($"Food is enough! Leftovers: {diff} grams.");
            }
            else
            {
                int diff = ate - (kgFoods * 1000);
                Console.WriteLine($"Food is not enough. You need {diff} grams more.");
            }
        }
    }
}
