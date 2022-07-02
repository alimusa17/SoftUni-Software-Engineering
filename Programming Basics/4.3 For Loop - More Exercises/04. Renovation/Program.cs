using System;

namespace _04._Renovation
{
    class Program
    {
        static void Main(string[] args)
        {
            int height = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int percent = int.Parse(Console.ReadLine());

            int total = height * width * 4;

            double toPaint = Math.Ceiling(total - total * 1.0 * percent / 100);

            string input = Console.ReadLine();       

            while (input != "Tired")                 
            {
                int liters = int.Parse(input);       
                toPaint -= liters;
                if (toPaint <= 0)
                {
                    break;
                }

                input = Console.ReadLine();
            }
            if (toPaint == 0)
            {
                Console.WriteLine("All walls are painted! Great job, Pesho!");
            }

            else if (toPaint > 0)
            {
                Console.WriteLine($"{toPaint} quadratic m left.");
            }

            else
            {
                Console.WriteLine($"All walls are painted and you have {toPaint * -1} l paint left!");
            }

        }
    }
}
