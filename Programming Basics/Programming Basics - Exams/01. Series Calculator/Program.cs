using System;

namespace _01._Series_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string movieName = Console.ReadLine();
            int seasons = int.Parse(Console.ReadLine());
            int episodes = int.Parse(Console.ReadLine());
            double episodeNoAds = double.Parse(Console.ReadLine());
            
            double adsOnEpisode = 0.2 * episodeNoAds;

            double episodeWithAds = adsOnEpisode + episodeNoAds;

            double extraEpisodes = seasons * 10;

            double totalTime = episodeWithAds * episodes * seasons + extraEpisodes;

            Console.WriteLine($"Total time needed to watch the {movieName} series is {Math.Floor(totalTime)} minutes.");
        }
    }
}
