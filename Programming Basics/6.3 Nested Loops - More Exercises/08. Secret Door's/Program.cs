using System;

namespace _08._Secret_Door_s_Lock
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num1; i++)
            {
                if (i % 2 != 0)
                {
                    continue;
                }
                for (int k = 1; k <= num2; k++)
                {
                    if (k == 1 || k == 4 || k == 6 || k == 8 || k == 9)
                    {
                        continue;
                    }
                    for (int j = 1; j <= num3; j++)
                    {

                        if (j % 2 != 0)
                        {
                            continue;
                        }
                        Console.WriteLine($"{i} {k} {j}");
                    }
                }
            }
        }
    }
}
