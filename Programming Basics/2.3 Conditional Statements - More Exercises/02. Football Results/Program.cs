using System;

namespace _02._Football_Results
{
    class Program
    {
        static void Main(string[] args)
        {
            string result1 = Console.ReadLine();
            string result2 = Console.ReadLine();
            string result3 = Console.ReadLine();

            char firstResult1 = result1 [0] ;
            char secondResult1 = result2 [2] ;

            int win = 0;
            int drawn = 0;
            int loses = 0;

            if (firstResult1 > secondResult1)
            {
                win++;
            }
            else if (firstResult1 == secondResult1)
            {
                drawn++;
            }
            else
            {
                loses++;
            }

            int firstResult2 = result2[0];
            int secondResult2 = result2[2];

            if (firstResult2 > secondResult2)
            {
                win++;
            }
            else if (firstResult2 == secondResult2)
            {
                drawn++;
            }
            else
            {
                loses++;
            }

            int firstResult3 = result3[0];
            int secondResult3 = result3[2];

            if (firstResult3 > secondResult3)
            {
                win++;
            }
            else if (firstResult3 == secondResult3)
            {
                drawn++;
            }
            else
            {
                loses++;
            }

            Console.WriteLine($"Team won {win} games.");
            Console.WriteLine($"Team lost {loses} games.");
            Console.WriteLine($"Drawn games: {drawn}");
        }
    }
}
