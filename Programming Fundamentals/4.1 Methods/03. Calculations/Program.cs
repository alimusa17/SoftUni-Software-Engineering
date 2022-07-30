using System;

namespace _03._Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            switch (command)
            {
                case "add":
                    AddNumbers(x, y);
                    break;
                case "multiply":
                    MultiplyNumbers(x, y);
                    break;
                case "subtract":
                    SubtractNumbers(x, y);
                    break;
                case "divide":
                    DivideNumbers(x, y);
                    break;
            }
        }

        static void AddNumbers(int x, int y)
        {
            Console.WriteLine(x + y);
        }

        static void MultiplyNumbers(int x, int y)
        {
            Console.WriteLine(x * y);
        }

        static void SubtractNumbers(int x, int y)
        {
            Console.WriteLine(x - y);
        }

        static void DivideNumbers(int x, int y)
        {
            Console.WriteLine(x / y);
        }
    }
}
