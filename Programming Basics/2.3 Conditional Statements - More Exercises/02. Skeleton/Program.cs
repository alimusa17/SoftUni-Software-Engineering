using System;

namespace _02._Skeleton
{
    class Program
    {
        static void Main(string[] args)
        {
            int minControl = int.Parse(Console.ReadLine());
            int secControl = int.Parse(Console.ReadLine());
            double distanceMeters = double.Parse(Console.ReadLine());
            int coverTime = int.Parse(Console.ReadLine());

            double controlInSec = minControl * 60 + secControl;

            double delay = distanceMeters / 120;

            delay = delay * 2.5;

            double timeMarin = (distanceMeters / 100) * coverTime - delay;

            if (controlInSec >= timeMarin)
            {
                Console.WriteLine("Marin Bangiev won an Olympic quota!");
                Console.WriteLine($"His time is {timeMarin:f3}.");
            }
            else
            {
                Console.WriteLine($"No, Marin failed! He was {timeMarin - controlInSec:f3} second slower.");
            }
        }
    }
}
