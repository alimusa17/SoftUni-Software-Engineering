﻿using System;

namespace _01._Student_Information
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            double avGrade = double.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {name}, Age: { age}, Grade: {avGrade:f2}");
        }
    }
}
