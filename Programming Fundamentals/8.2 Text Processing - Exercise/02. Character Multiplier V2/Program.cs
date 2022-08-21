using System;

namespace _02._Character_Multiplier_V2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ");

            Console.WriteLine(CharMultiplier(input[0], input[1]));
        }

        public static int CharMultiplier(string str1, string str2)
        {
            int sum = 0;

            int max = Math.Max(str1.Length, str2.Length);
            int min = Math.Min(str1.Length, str2.Length);

            string longest = str2;

            if (str1.Length > str2.Length)
            {
                longest = str1;
            }

            for (int i = 0; i < min; i++)
            {
                sum += str1[i] * str2[i];
            }

            for (int i = min; i < max; i++)
            {
                sum += longest[i];
            }

            return sum;
        }
    }
}
