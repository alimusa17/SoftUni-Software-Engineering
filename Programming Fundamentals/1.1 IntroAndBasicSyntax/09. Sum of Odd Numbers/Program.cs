﻿using System;

namespace _09._Sum_of_Odd_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumOfOddNumbers = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < sumOfOddNumbers; i++)
            {
                int currentOddNumber = 1 + (i * 2);

                Console.WriteLine(currentOddNumber);
                sum += currentOddNumber;
            }

            Console.WriteLine($"Sum: {sum}");
        }
    }
}
