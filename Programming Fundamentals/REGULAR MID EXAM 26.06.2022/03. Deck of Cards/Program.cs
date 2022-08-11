using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Deck_of_Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> cards = Console.ReadLine().Split(", ").ToList();

            int numberofCommandsN = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numberofCommandsN; i++)
            {
                List<string> command = Console.ReadLine().Split(", ").ToList();

                if (command[0] == "Add")
                {

                    if (cards.Contains(command[1]))
                    {
                        Console.WriteLine("Card is already in the deck");
                    }
                    else
                    {
                        cards.Add(command[1]);
                        Console.WriteLine("Card successfully added");
                    }
                }

                if (command[0] == "Remove")
                {
                    if (!cards.Contains(command[1]))
                    {
                        Console.WriteLine("Card not found");
                    }
                    else
                    {
                        cards.Remove(command[1]);
                        Console.WriteLine("Card successfully removed");
                    }
                }

                if (command[0] == "Remove At")
                {
                    int index = int.Parse(command[1]);
                    if (index < 0 || index >= cards.Count)
                    {
                        Console.WriteLine("Index out of range");
                    }
                    else
                    {
                        cards.RemoveAt(index);
                        Console.WriteLine("Card successfully removed");
                    }
                }

                if (command[0] == "Insert")
                {
                    int indexToInsertAt = int.Parse(command[1]);
                    string cardToInsert = command[2];

                    if (indexToInsertAt < 0 || indexToInsertAt >= cards.Count)
                    {
                        Console.WriteLine("Index out of range");
                    }
                    else
                    {
                        if (cards.Contains(cardToInsert))
                        {
                            Console.WriteLine("Card is already added");
                        }
                        else
                        {
                            cards.Insert(indexToInsertAt, cardToInsert);
                            Console.WriteLine("Card successfully added");
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(", ", cards));
        }
    }
}
