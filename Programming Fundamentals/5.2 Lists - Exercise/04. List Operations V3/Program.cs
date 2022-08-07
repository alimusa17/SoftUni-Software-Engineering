using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._List_Operations_V3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string[] userInput = Console.ReadLine().Split();

            while (userInput[0] != "End")
            {
                string currentAction = userInput[0];
                int firstNumber = 0;

                if (userInput[1] != "left" && userInput[1] != "right")
                {
                    firstNumber = int.Parse(userInput[1]);
                }
                else
                {
                    firstNumber = int.Parse(userInput[2]);
                }

                switch (currentAction)
                {
                    case "Add":
                        AddNumberToList(firstNumber, numbers);
                        break;

                    case "Insert":
                        int secondNumber = int.Parse(userInput[2]);
                        InsertNumberToList(firstNumber, secondNumber, numbers);
                        break;

                    case "Remove":
                        RemoveNumberAtIndexFromList(firstNumber, numbers);
                        break;

                    case "Shift":
                        if (userInput[1] == "left")
                        {
                            numbers = ShiftListToLeft(firstNumber, numbers);
                        }
                        else if (userInput[1] == "right")
                        {
                            numbers = ShiftListToRight(firstNumber, numbers);
                        }
                        break;
                }

                userInput = Console.ReadLine().Split();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }

        static void AddNumberToList(int addedNumber, List<int> currentList)
        {
            currentList.Add(addedNumber);
        }

        static void InsertNumberToList(int addedNumber, int indexInList, List<int> currentList)
        {
            if (indexInList < currentList.Count && indexInList >= 0)
            {
                currentList.Insert(indexInList, addedNumber);
            }
            else
            {
                Console.WriteLine("Invalid index");
            }
        }

        static void RemoveNumberAtIndexFromList(int indexInList, List<int> currentList)
        {
            if (indexInList < currentList.Count && indexInList >= 0)
            {
                currentList.RemoveAt(indexInList);
            }
            else
            {
                Console.WriteLine("Invalid index");
            }
        }

        static List<int> ShiftListToLeft(int shiftAmount, List<int> currentList)
        {
            List<int> tempList = new List<int>();

            for (int i = 0; i < currentList.Count; i++)
            {
                tempList.Add(currentList[i]);
            }

            for (int i = 0; i < shiftAmount; i++)
            {
                int firstNumberInList = tempList[0];

                for (int j = 0; j < tempList.Count - 1; j++)
                {
                    tempList[j] = tempList[j + 1];
                }

                tempList[tempList.Count - 1] = firstNumberInList;
            }

            return tempList;
        }

        static List<int> ShiftListToRight(int shiftAmount, List<int> currentList)
        {
            List<int> tempList = new List<int>();

            for (int i = 0; i < currentList.Count; i++)
            {
                tempList.Add(currentList[i]);
            }

            for (int i = 0; i < shiftAmount; i++)
            {
                int lastNumberInList = tempList[tempList.Count - 1];

                for (int j = tempList.Count - 1; j > 0; j--)
                {
                    tempList[j] = tempList[j - 1];
                }

                tempList[0] = lastNumberInList;
            }

            return tempList;
        }
    }
}
