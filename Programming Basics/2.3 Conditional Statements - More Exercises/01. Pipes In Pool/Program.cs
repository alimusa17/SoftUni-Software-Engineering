using System;

namespace _01._Pipes_In_Pool
{
    class Program
    {
        static void Main(string[] args)
        {
            int poolVolume = int.Parse(Console.ReadLine());
            int rateFirstPipePerHour = int.Parse(Console.ReadLine());
            int rateSecondPipePerHour = int.Parse(Console.ReadLine());
            double workerAsent = double.Parse(Console.ReadLine());

            double poolVolumeFirstPipe = workerAsent * rateFirstPipePerHour;
            double poolVolumeSecondPipe = workerAsent * rateSecondPipePerHour;

            double totalPoolVolume = poolVolumeFirstPipe + poolVolumeSecondPipe;

            if (poolVolume > totalPoolVolume)
            {
                double totalPercent = ((100 * totalPoolVolume) / poolVolume);
                double percentPipe1 = ((10 * poolVolumeFirstPipe / totalPercent));
                double percentPipe2 = ((10 * poolVolumeSecondPipe / totalPercent));

                Console.WriteLine($"The pool is {totalPercent:F2}% full. Pipe 1: {percentPipe1:F2}%. Pipe 2: {percentPipe2:F2}%.");
            }
            else
            {
                double overflowsWater = totalPoolVolume - poolVolume;

                Console.WriteLine($"For {workerAsent:F2} hours the pool overflows with {overflowsWater:F2} liters.");
            }
        }
    }
}

