using System;

namespace _04._Train_The_Trainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();

            double presentationEv;

            int presentationNum = 0;
            double evaluation = 0;

            string presentationName;

            while (input != "Finish")
            {
                presentationName = input;

                presentationEv = 0;

                for (int i = 1; i <= n; i++)
                {
                    presentationEv += double.Parse(Console.ReadLine());
                }
                presentationEv = presentationEv / n;

                evaluation += presentationEv;

                Console.WriteLine($"{input} - {presentationEv:f2}.");

                presentationNum++;

                input = Console.ReadLine();
            }
            Console.WriteLine($"Student's final assessment is {evaluation/presentationNum:f2}.");
        }
    }
}
