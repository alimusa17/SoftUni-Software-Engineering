using System;

namespace _03._Extract_File
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split('\\', StringSplitOptions.RemoveEmptyEntries);

            string[] fileName = input[input.Length - 1].Split('.');

            Console.WriteLine("File name: " + fileName[0]);
            Console.WriteLine("File extension: " + fileName[1]);
        }
    }
}

