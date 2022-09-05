using System;

namespace _02._Movie_Day
{
    class Program
    {
        static void Main(string[] args)
        {
            int timeForPhotos = int.Parse(Console.ReadLine());
            int numOfScenes = int.Parse(Console.ReadLine());
            int durationScene = int.Parse(Console.ReadLine());

            double preparationTeren = timeForPhotos * 0.15;

            int timeForScenes = numOfScenes * durationScene;

            double neededTime = preparationTeren + timeForScenes;

            if (timeForPhotos >= neededTime)
            {
                Console.WriteLine($"You managed to finish the movie on time! You have {Math.Abs(timeForPhotos-neededTime)} minutes left!");
            }
            else
            {
                Console.WriteLine($"Time is up! To complete the movie you need {Math.Abs(neededTime-timeForPhotos)} minutes.");
            }
        }
    }
}
