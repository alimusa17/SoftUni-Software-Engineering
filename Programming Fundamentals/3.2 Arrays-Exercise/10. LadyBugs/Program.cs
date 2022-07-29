using System;
using System.Linq;

namespace _10._LadyBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int fieldLength = int.Parse(Console.ReadLine());
            int[] ladybugIndexes = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[] field = new int[fieldLength];
            bool hasLadybug = false;
            foreach (int index in ladybugIndexes)
            {
                if (0 <= index && index < fieldLength)
                {
                    field[index] = 1;
                    hasLadybug = true;
                }
            }

            if (!hasLadybug) return;

            string input = Console.ReadLine();
            while (!input.Equals("end"))
            {
                string[] inputParameters = input.Split();

                int ladybugIndex = int.Parse(inputParameters[0]);
                if (0 <= ladybugIndex && ladybugIndex < fieldLength && field[ladybugIndex] == 1)
                {
                    field[ladybugIndex] = 0;

                    int moveSteps = int.Parse(inputParameters[2]);
                    if (inputParameters[1].Equals("left"))
                        moveSteps = -moveSteps;

                    int newLadybugIndex = ladybugIndex + moveSteps;

                    while (0 <= newLadybugIndex && newLadybugIndex < fieldLength && field[newLadybugIndex] == 1)
                    {
                        newLadybugIndex += moveSteps;
                    }

                    if (0 <= newLadybugIndex && newLadybugIndex < fieldLength)
                        field[newLadybugIndex] = 1;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", field));
        }
    }
}
