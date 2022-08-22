using System;

namespace _08._Letters_Change_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries); //A12b;  s17G  

            double sum = 0;

            foreach (var item in input)             // A12b
            {
                char firstLetter = item[0];         // 'A'
                char lastLetter = item[item.Length - 1];  // 'b'

                double number = double.Parse(item.Substring(1, item.Length - 2));  // 12

                double result = 0;

                //int firstLetterPositionInTheAlphabet = firstLetter - 64;
                // check if upper:

                if (firstLetter >= 65 && firstLetter <= 90)
                {
                    int firstLetterPositionInTheAlphabet = firstLetter - 64;
                    result = number / firstLetterPositionInTheAlphabet;
                }

                else
                {
                    int firstLetterPositionInTheAlphabet = firstLetter - 96;
                    result = number * firstLetterPositionInTheAlphabet;
                }

                if (lastLetter >= 65 && lastLetter <= 90)
                {
                    int lastLetterPositionInTheAlphabet = lastLetter - 64;
                    sum += result - lastLetterPositionInTheAlphabet;
                }

                else
                {
                    int lastLetterPositionInTheAlphabet = lastLetter - 96;
                    sum += result + lastLetterPositionInTheAlphabet;
                }
            }

            Console.WriteLine($"{sum:f2}");
        }
    }
}
