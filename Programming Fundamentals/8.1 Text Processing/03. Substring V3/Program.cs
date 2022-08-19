﻿using System;

namespace _03._Substring_V2
{
    class Program
    {
        static void Main(string[] args)
        {
            string substringToRemove = Console.ReadLine();
            string fullString = Console.ReadLine();

            while (fullString.Contains(substringToRemove))
            {
                fullString = fullString.Replace(substringToRemove, string.Empty);
            }

            Console.WriteLine(fullString);
        }
    }
}
