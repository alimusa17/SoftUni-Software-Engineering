using System;

namespace _06._World_Swimming_Record
{
    class Program
    {
        static void Main(string[] args)
        {
            double worldRecord = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double timePerMeter = double.Parse(Console.ReadLine());

            double delay = distance / 15;
            delay = Math.Floor(delay);
            delay = delay * 12.5;

            double recordIvan = distance * timePerMeter + delay;

            if (recordIvan < worldRecord)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {(recordIvan):f2} seconds.");
            }

            else
            {
                Console.WriteLine($"No, he failed! He was {(recordIvan - worldRecord):f2} seconds slower.");
            }
        }
    }
}
