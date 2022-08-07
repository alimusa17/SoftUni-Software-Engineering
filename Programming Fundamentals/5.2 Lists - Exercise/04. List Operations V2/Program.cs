using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._List_Operations_V2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbersList = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command;

            while ((command = Console.ReadLine()) != "End")
            {
                string[] cmdArgs = command.Split();
                switch (cmdArgs[0])
                {
                    case "Add":
                        numbersList.Add(int.Parse(cmdArgs[1]));
                        break;

                    case "Insert":
                        int numberToInsert = int.Parse(cmdArgs[1]);
                        int indexToInsertAt = int.Parse(cmdArgs[2]);

                        if (indexToInsertAt >= 0 && indexToInsertAt < numbersList.Count)
                        {
                            numbersList.Insert(indexToInsertAt, numberToInsert);
                        }
                        else
                        {
                            Console.WriteLine("Invalid index");
                        }
                        break;

                    case "Remove":
                        int indexToRemove = int.Parse(cmdArgs[1]);
                        if (indexToRemove >= 0 && indexToRemove < numbersList.Count)
                        {
                            numbersList.RemoveAt(indexToRemove);
                        }
                        else
                        {
                            Console.WriteLine("Invalid index");
                        }
                        break;

                    case "Shift":
                        int count = int.Parse(cmdArgs[2]);
                        if (cmdArgs[1] == "left")
                        {
                            numbersList = ShiftLeft(numbersList, count);
                        }
                        else
                        {
                            numbersList = ShiftRight(numbersList, count);
                        }
                        break;
                }
            }
            Console.WriteLine(string.Join(" ", numbersList));
        }

        static List<int> ShiftLeft(List<int> numberListToShift, int count)
        {
            for (int i = 0; i < count; i++)
            {
                numberListToShift.Add(numberListToShift[0]);
                numberListToShift.RemoveAt(0);
            }
            return numberListToShift;
        }

        static List<int> ShiftRight(List<int> numberListToShift, int count)
        {
            for (int i = 0; i < count; i++)
            {
                numberListToShift.Insert(0, numberListToShift[numberListToShift.Count - 1]);
                numberListToShift.RemoveAt(numberListToShift.Count - 1);
            }
            return numberListToShift;
        }
    }
}
