using System;
using System.Collections.Generic;
using System.Text;

namespace _07._String_Explosion
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            // abv>1>1>2>2asdasd

            StringBuilder sb = new StringBuilder();

            int power = 0;

            for (int i = 0; i < input.Length; i++)
            {
                char current = input[i];

                // 1. Not explosion (not '>'), character stays
                // 2. Not explosion, characters is omitted (prev char was an explosion)
                // 3. Explosion (char == '>')

                if (current == '>')
                {
                    power += int.Parse(input[i + 1].ToString());
                    sb.Append(current);
                }
                else if (power == 0)
                {
                    sb.Append(current);
                }
                else
                {
                    power--;
                }
            }

            Console.WriteLine(sb);
        }
    }
}
