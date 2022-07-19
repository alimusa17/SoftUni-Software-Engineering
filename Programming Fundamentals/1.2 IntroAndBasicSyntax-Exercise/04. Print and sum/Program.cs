using System;

namespace _04._Print_and_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int value = startNum; value <= endNum; value++)
            {
                Console.Write($"{value} ");
                sum += value;
            }

            Console.WriteLine();
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
