using System;
using System.Linq;

namespace _05._Top_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < inputArray.Length; i++)
            {
                int currIterattionNum = inputArray[i];
                bool currIterattionNumIsBigger = true;
                for (int j = i + 1; j < inputArray.Length; j++)
                {
                    int nextIterattionNum = inputArray[j];
                    if (currIterattionNum <= nextIterattionNum)
                    {
                        currIterattionNumIsBigger = false;
                        break;
                    }
                }

                if (currIterattionNumIsBigger)
                {
                    Console.Write($"{currIterattionNum} ");
                }
            }
        }
    }
}
