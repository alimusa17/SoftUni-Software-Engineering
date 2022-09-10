using System;

namespace _04._Cinema_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int capacity = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();                  //string == число или текст
            int totalSum = 0;

            while (input != "Movie time!")
            {
                int peopleCount = int.Parse(Console.ReadLine());
                capacity -= peopleCount;

                if (peopleCount % 3 == 0)
                {
                    totalSum += peopleCount * 5 - 5;
                }
                else
                {
                    totalSum += peopleCount * 5;
                }

                if (peopleCount > capacity)
                {
                    break;
                }

                input = Console.ReadLine();
            }

            if (capacity >= 0)
            {
                Console.WriteLine($"There are {capacity}seats left in the cinema.");
            }
            else
            {
                Console.WriteLine("The cinema is full.");
            }

            Console.WriteLine($"Cinema income - {totalSum} lv.");

        }
    }
}
