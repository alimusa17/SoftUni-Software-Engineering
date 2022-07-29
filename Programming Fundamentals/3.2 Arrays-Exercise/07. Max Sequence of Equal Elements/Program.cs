using System;
using System.Linq;

namespace _07._Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int bestCount = 0, currCount = 1, sequenceNumber = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    currCount++;
                    if (currCount > bestCount)
                    {
                        bestCount = currCount;
                        sequenceNumber = numbers[i - 1];
                    }
                }
                else
                {
                    currCount = 1;
                }
            }

            Console.WriteLine(string.Join(" ", Enumerable.Repeat(sequenceNumber, bestCount)));
        }
    }
}
