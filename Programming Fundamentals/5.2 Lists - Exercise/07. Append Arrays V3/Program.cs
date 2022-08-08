using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Append_Arrays_V3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] allArrays = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries);
            List<int> finalList = new List<int>();

            for (int i = allArrays.Length - 1; i >= 0; i--)
            {
                int[] tempArray = allArrays[i]
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int j = 0; j < tempArray.Length; j++)
                {
                    finalList.Add(tempArray[j]);
                }
            }
            Console.WriteLine(string.Join(" ", finalList));
        }
    }
}
