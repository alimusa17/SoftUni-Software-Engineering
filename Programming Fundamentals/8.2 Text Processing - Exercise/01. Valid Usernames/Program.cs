using System;
using System.Collections.Generic;

namespace _01._Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            //Jeff, john45, ab, cd, peter-ivanov, @smith

            List<string> validUsernames = new List<string>();

            // •	has length between 3 and 16 characters
            // •	contains only letters, numbers, hyphens and underscores

            foreach (var username in input)
            {
                if (username.Length >= 3 && username.Length <= 16)
                {
                    bool isValid = true;

                    for (int i = 0; i < username.Length; i++)
                    {
                        char currentChar = username[i];

                        if (!(currentChar == '-' || currentChar == '_' || char.IsDigit(currentChar) || char.IsLetter(currentChar)))
                        {
                            isValid = false;
                            break;
                        }
                    }

                    if (isValid)
                    {
                        validUsernames.Add(username);
                    }
                }
            }

            Console.WriteLine(String.Join(Environment.NewLine, validUsernames));

        }
    }
}
