using System;

namespace _02._Sleepy_Tom_Cat
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbersDayOff = int.Parse(Console.ReadLine());
            int numbersDaysWorking = 365 - numbersDayOff;
            int normOfPlay = 30000;
            int timeToPlay = numbersDaysWorking * 63 + numbersDayOff * 127;

            int difference = Math.Abs(normOfPlay - timeToPlay);    

            if (timeToPlay > normOfPlay)
            {
                double hours = difference / 60;
                double minutes = difference % 60;

                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{hours} hours and {minutes} minutes more for play");
            }
            else
            {
                double hours = difference / 60;
                double minutes = difference % 60;

                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{(hours)} hours and {(minutes)} minutes less for play");
            }
        }
    }
}
