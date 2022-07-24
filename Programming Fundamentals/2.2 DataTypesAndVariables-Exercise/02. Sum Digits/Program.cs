using System;

namespace _02._Sum_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] charArray = input.ToCharArray();
            int finalSum = 0;

            for (int value = 0; value < charArray.Length; value++)
            {
                finalSum += int.Parse(charArray[value].ToString());
            }

            Console.WriteLine(finalSum);
        }
    }
}
