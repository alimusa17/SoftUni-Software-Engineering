using System;

namespace _11._Math_Operations_V2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Calculate(int.Parse(Console.ReadLine()), char.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())));
        }

        private static double Calculate(int a, char @operator, int b)
        {
            return @operator switch
            {
                '/' => 1.0 * a / b,
                '*' => a * b,
                '+' => a + b,
                '-' => a - b
            };
        }
    }
}
