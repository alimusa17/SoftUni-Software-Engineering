using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Bomb_Numbers_V3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbersList = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] cmdArgs = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int bombNumber = cmdArgs[0];
            int bombPower = cmdArgs[1];

            while (numbersList.Contains(bombNumber))
            {
                // EXPLODE INDEXES PRIOR TO THE BOMB
                for (int i = 0; i < bombPower; i++)
                {
                    if (numbersList.IndexOf(bombNumber) - 1 >= 0)
                    {
                        numbersList.RemoveAt(numbersList.IndexOf(bombNumber) - 1);
                    }
                    else
                    {
                        break;
                    }
                }
                // EXPLODE INDEXES AFTER BOMB 
                for (int i = 0; i < bombPower; i++)
                {
                    if (numbersList.IndexOf(bombNumber) + 1 > numbersList.Count - 1)
                    {
                        break;
                    }
                    else
                    {
                        numbersList.RemoveAt(numbersList.IndexOf(bombNumber) + 1);
                    }
                }
                // EXPLODE BOMB
                numbersList.RemoveAt(numbersList.IndexOf(bombNumber));
            }
            Console.WriteLine(numbersList.Sum());
        }
    }
}

