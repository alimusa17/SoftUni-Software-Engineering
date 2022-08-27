using System;
using System.Collections.Generic;

namespace _03._Degustation_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> guests = new Dictionary<string, List<string>>();
            int unlikedMeals = 0;
            string input;

            while ((input = Console.ReadLine()) != "Stop")
            {
                string[] cmdTokens = input.Split('-', StringSplitOptions.RemoveEmptyEntries);
                string prefer = cmdTokens[0];

                if (prefer == "Like")
                {
                    string guestName = cmdTokens[1];
                    string meal = cmdTokens[2];

                    if (guests.ContainsKey(guestName))
                    {
                        if (guests[guestName].Contains(meal))
                        {
                        }
                        else
                        {
                            guests[guestName].Add(meal);
                        }
                    }
                    else
                    {
                        guests.Add(guestName, new List<string>());
                        guests[(guestName)].Add(meal);
                    }
                }

                else if (prefer == "Dislike")
                {
                    string guestName = cmdTokens[1];
                    string meal = cmdTokens[2];

                    if (guests.ContainsKey(guestName))
                    {
                        if (guests[guestName].Contains(meal))
                        {
                            guests[guestName].Remove(meal);
                            Console.WriteLine($"{guestName} doesn't like the {meal}.");
                            unlikedMeals++;
                        }
                        else
                        {
                            Console.WriteLine($"{guestName} doesn't have the {meal} in his/her collection.");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"{guestName} is not at the party.");
                    }
                }
            }
            foreach (var guest in guests)
            {
                Console.WriteLine($"{guest.Key}: {string.Join(", ", guest.Value)}");
            }
            Console.WriteLine($"Unliked meals: {unlikedMeals}");
        }
    }
}

