using System;

namespace _04._Darts
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int totalPoints = 301;
            int successfulShots = 0;
            int unSuccessfulShots = 0;

            while (totalPoints != 0)
            {
                string area = Console.ReadLine();
                if (area == "Retire")
                {
                    break;
                }

                int points = int.Parse(Console.ReadLine());

                if (area == "Triple")
                {
                    points *= 3;
                }
                else if (area == "Double")
                {
                    points *= 2;
                }

                if (totalPoints - points >= 0)
                {
                    totalPoints -= points;
                    successfulShots++;
                }
                else
                {
                    unSuccessfulShots++;
                }
            }

            if (totalPoints == 0)
            {
                Console.WriteLine($"{name} won the leg with {successfulShots} shots.");
            }
            else
            {
                Console.WriteLine($"{name} retired after {unSuccessfulShots} unsuccessful shots.");
            }

        }
    }
}
