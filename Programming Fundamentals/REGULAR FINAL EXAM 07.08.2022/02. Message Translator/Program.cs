using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02._Message_Translator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string patternForTranslate = @"!(?<command>[A-Z][a-z]{2,})!:\[(?<message>[a-zA-Z]{8,})\]";

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                Match match = Regex.Match(input, patternForTranslate);

                if (match.Success)
                {
                    string command = match.Groups["command"].Value;
                    string message = match.Groups["message"].Value;

                    List<int> numbersList = new List<int>();
                    for (int j = 0; j < message.Length; j++)
                    {
                        int letterASCIICode = (int)message[j];
                        numbersList.Add(letterASCIICode);
                    }

                    Console.WriteLine($"{command}: {string.Join(" ", numbersList)}");
                }
                else
                {
                    Console.WriteLine("The message is invalid");
                }
            }
        }
    }
}

