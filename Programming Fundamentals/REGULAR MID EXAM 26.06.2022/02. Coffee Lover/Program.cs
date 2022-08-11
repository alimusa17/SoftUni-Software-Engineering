using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Coffee_Lover
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> coffees = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

            int numberOfCommand = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numberOfCommand; i++)
            {
                List<string> commands = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

                if (commands[0] == "Include")
                {
                    coffees.Add(commands[1]);
                }

                else if (commands[0] == "Remove")
                {
                    int numbersOfCoffeesToRemove = int.Parse(commands[2]);

                    if (coffees.Count < numbersOfCoffeesToRemove)
                    {
                        continue;
                    }

                    if (commands[1] == "first")
                    {
                        coffees.RemoveRange(0, numbersOfCoffeesToRemove);
                    }

                    else if (commands[1] == "last")
                    {
                        coffees.RemoveRange(coffees.Count - numbersOfCoffeesToRemove, numbersOfCoffeesToRemove);
                    }
                }

                else if (commands[0] == "Prefer")
                {
                    int index1 = int.Parse(commands[1]);
                    int index2 = int.Parse(commands[2]);

                    if (index1 >= 0 && index1 < coffees.Count && index2 >= 0 && index2 < coffees.Count)
                    {
                        string tempCoffee1 = coffees[index1];
                        coffees[index1] = coffees[index2];
                        coffees[index2] = tempCoffee1;
                    }
                }

                else if (commands[0] == "Reverse")
                {
                    coffees.Reverse();
                }
            }

            Console.WriteLine("Coffees:");
            Console.WriteLine(string.Join(" ", coffees));
        }
    }
}

