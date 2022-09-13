using System;

namespace _09._Clock
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 24 * 60; i++)
            {
                Console.WriteLine($"{i / 60} : {i % 60}");
            }
        }
    }
}