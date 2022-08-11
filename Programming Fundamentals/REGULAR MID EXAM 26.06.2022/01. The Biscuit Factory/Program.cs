using System;

namespace _01._The_Biscuit_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            double amountBiscits = double.Parse(Console.ReadLine());
            int countWorkers = int.Parse(Console.ReadLine());
            int amountBiscuitsFactory = int.Parse(Console.ReadLine());

            double sum = 0;

            for (int days = 1; days <= 30; days++)
            {
                if (days % 3 != 0)
                {
                    sum += amountBiscits * countWorkers;
                }
                else
                {
                    int current = (int)Math.Floor(0.75 * amountBiscits * countWorkers);
                    sum += current;
                }
            }
            Console.WriteLine($"You have produced {sum} biscuits for the past month.");

            if (amountBiscuitsFactory > sum)
            {
                Console.WriteLine("You produce {0:f2} percent less biscuits.", ((amountBiscuitsFactory - sum) / amountBiscuitsFactory) * 100);
            }
            else
            {
                Console.WriteLine("You produce {0:f2} percent more biscuits.", ((amountBiscuitsFactory - sum) / amountBiscuitsFactory) * 100 * -1);
            }
        }
    }
}

