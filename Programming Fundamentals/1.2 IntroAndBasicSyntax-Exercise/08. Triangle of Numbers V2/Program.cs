using System;

namespace _08._Triangle_of_Numbers_V2
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (var row = 1; row <= n; row++)
            {
                Console.Write("$");

                for (var col = 1; col < row; col++)
                {
                    Console.Write(" $");
                }
                Console.WriteLine();
            }
        }
    }
}
