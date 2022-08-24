using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text;
using System.Linq;

namespace _04._Star_Enigma
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> attackedPlanetsList = new List<string>();
            List<string> destroyedPlanetsList = new List<string>();

            int lines = int.Parse(Console.ReadLine());
            for (int i = 0; i < lines; i++)
            {
                string input = Console.ReadLine();
                MatchCollection letters = Regex.Matches(input, @"[starSTAR]");

                StringBuilder sb = new StringBuilder();
                foreach (var ch in input)
                {
                    sb.Append((char)((int)ch - letters.Count));
                }

                Match match = Regex.Match(sb.ToString(), @"@(?<planet>\p{L}+)[^@\-!:>]*?:\d+[^@\-!:>]*?!(?<attacktype>[AD])![^@\-!:>]*?");

                if (match.Groups["attacktype"].Value == "A")
                {
                    attackedPlanetsList.Add("-> " + match.Groups["planet"].Value);
                }
                else if (match.Groups["attacktype"].Value == "D")
                {
                    destroyedPlanetsList.Add("-> " + match.Groups["planet"].Value);
                }
            }

            Console.WriteLine("Attacked planets: " + attackedPlanetsList.Count);
            attackedPlanetsList.OrderBy(x => x).ToList().ForEach(x => Console.WriteLine(x));
            Console.WriteLine("Destroyed planets: " + destroyedPlanetsList.Count);
            destroyedPlanetsList.OrderBy(x => x).ToList().ForEach(x => Console.WriteLine(x));
        }
    }
}
