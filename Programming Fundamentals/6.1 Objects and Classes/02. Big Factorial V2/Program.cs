﻿using System;
using System.Numerics;

namespace _02._Big_Factorial_V2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            BigInteger f = 1;

            for (int i = 2; i < n; i++)
            {
                f *= n;
            }

            Console.WriteLine(f);
        }
    }
}
