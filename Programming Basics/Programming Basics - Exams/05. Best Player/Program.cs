using System;

namespace _05._Best_Player
{
    class Program
    {
        static void Main(string[] args)
        {
            string playerName = Console.ReadLine();
            int scoringGoals = 0;
            string bestPlayer = "";
            
            while (playerName!= "END")
            {
                int currentGoals = int.Parse(Console.ReadLine());
                if (currentGoals > scoringGoals)
                {
                    bestPlayer = playerName;
                    scoringGoals = currentGoals;
                }
            
                if (scoringGoals >= 10)
                {
                    break;
                }
            }
            
            Console.WriteLine($"{bestPlayer} is the best player!");
            if (scoringGoals >= 3)
            {
                Console.WriteLine($"He has scored {scoringGoals} goals and made a hat-trick !!!");
            }
            else
            {
                Console.WriteLine($"He has scored {scoringGoals} goals.");
            }
   
        }
    }
}
