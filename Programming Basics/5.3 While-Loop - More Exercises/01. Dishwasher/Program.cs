using System;

namespace _01._Dishwasher
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfBottles = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int detergent = numberOfBottles * 750;
            int count = 0;
            int plates = 0;
            int pots = 0;

            while (input != "End")
            {
                count++;
                if (count % 3 == 0)
                {
                    detergent -= 15 * int.Parse(input);
                    pots += int.Parse(input);
                }
                else
                {
                    detergent -= 5 * int.Parse(input);
                    plates += int.Parse(input);
                }
                if (detergent <= 0)
                {
                    Console.WriteLine($"Not enough detergent, {Math.Abs(detergent)} ml. more necessary!");
                    break;
                }
                input = Console.ReadLine();
            }
            if (input == "End")
            {
                Console.WriteLine($"Detergent was enough!");
                Console.WriteLine($"{plates} dishes and {pots} pots were washed.");
                Console.WriteLine($"Leftover detergent {detergent} ml.");
            }
        }

    }
}
