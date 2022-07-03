using System;

namespace _04._Gifts_from_Santa
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int s = int.Parse(Console.ReadLine());

            for (int i = m; i >= n; i--)
            {
                if (i % 6 == 0)
                {
                    if (i == s)
                    {
                        break;
                    }
                    Console.WriteLine($"{i}");
                }
            }

        }
    }
}
