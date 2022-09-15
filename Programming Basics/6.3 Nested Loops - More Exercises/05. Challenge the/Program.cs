using System;

namespace _05._Challenge_the_Wedding
{
    class Program
    {
        static void Main(string[] args)
        {
            int gentleman = int.Parse(Console.ReadLine());
            int ladies = int.Parse(Console.ReadLine());
            int tables = int.Parse(Console.ReadLine());

            int counter = 0;

            for (int i = 1; i <= gentleman; i++)
            {
                for (int l = 1; l <= ladies; l++)
                {
                    counter++;

                    if (counter <= tables)
                    {
                        Console.Write($"({i} <-> {l}) ");
                    }
                }
            }
        }
    }
}