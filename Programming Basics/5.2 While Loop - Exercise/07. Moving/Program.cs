using System;

namespace _07._Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            int volume = width * length * height;

            string count = Console.ReadLine();

            while (count != "Done")
            {
                int countNumber = int.Parse(count);
                volume -= countNumber;
                if (volume < 0)
                {
                    Console.WriteLine($"No more free space! You need {Math.Abs(volume)} Cubic meters more.");
                    return;
                }
                count = Console.ReadLine();
            }
            Console.WriteLine($"{volume} Cubic meters left.");
        }
    }
}
