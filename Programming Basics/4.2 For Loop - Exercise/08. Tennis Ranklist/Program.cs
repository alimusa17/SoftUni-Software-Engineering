using System;

namespace _08._Tennis_Ranklist
{
    class Program
    {
        static void Main(string[] args)
        {
            const int FINALIST_POINTS = 1200;
            const int WINNER_POINTS = 2000;
            const int SEMIFINAL_POINTS = 720;
            int numOfTournaments = int.Parse(Console.ReadLine());
            int startingPoints = int.Parse(Console.ReadLine());
            int points = 0;
            double average = 0;
            double percents = 0;
            int numberOfWonTournaments = 0;
            points = startingPoints;

            for (int iterator = 0; iterator < numOfTournaments; iterator++)
            {
               string currentStage = Console.ReadLine();
                if (currentStage == "F")
                {
                    points += FINALIST_POINTS;
                }
                else if (currentStage == "W")
                {
                    points += WINNER_POINTS;
                    numberOfWonTournaments++;
                }
                else if (currentStage == "SF")
                {
                    points += SEMIFINAL_POINTS;
                }
            }

            average = (points - startingPoints) / numOfTournaments;
            percents = ((double)numberOfWonTournaments / numOfTournaments) * 100;

            Console.WriteLine($"Final points: {points}");
            Console.WriteLine($"Average points: {Math.Floor(average)}");
            Console.WriteLine($"{percents:f2}%");

        }
    }
}
