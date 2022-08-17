using System;
using System.Collections.Generic;

namespace _01._Count_Chars_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] word = Console.ReadLine().ToCharArray(); // "text" => ['t', 'e', 'x', 't'] 

            Dictionary<char, int> letters = new Dictionary<char, int>(); // {char: int} => {char 't': int2}

            foreach (var letter in word)
            {
                if (letter != ' ')
                {
                    if (!letters.ContainsKey(letter)) //letters.ContainsKey('t')
                    {
                        letters[letter] = 0;
                    }
                    letters[letter]++;
                }
            }

            foreach (var kvpLetter in letters)
            {
                Console.WriteLine($"{kvpLetter.Key} -> {kvpLetter.Value}"); // t -> 2
            }
        }
    }
}

