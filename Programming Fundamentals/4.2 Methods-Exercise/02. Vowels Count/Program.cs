using System;
using System.Linq;

namespace _02._Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputText = Console.ReadLine().ToLower();

            SearchForVoweles(inputText);
        }

        private static void SearchForVoweles(string text)
        {
            int count = text.Count(volwe => "aouei".Contains(volwe));

            Console.WriteLine(count);
        }
    }
}
