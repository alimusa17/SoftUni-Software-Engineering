using System;

namespace _02._AND_Processors
{
    class Program
    {
        static void Main(string[] args)
        {
            int neededProcessors = int.Parse(Console.ReadLine());
            int numEmployees = int.Parse(Console.ReadLine());
            int workDays = int.Parse(Console.ReadLine());

            double workingHours = numEmployees * workDays * 8;

            double processorsMade = Math.Floor(workingHours / 3);
                        
            if (processorsMade >= neededProcessors)
            {
                double profit = (processorsMade - neededProcessors) * 110.10;
                Console.WriteLine($"Profit: -> {profit:f2} BGN");
            }
            else if (processorsMade < neededProcessors)
            {
                double losses = (neededProcessors - processorsMade) * 110.10;
                Console.WriteLine($"Losses: -> {losses:f2} BGN");
            }

        }
    }
}
