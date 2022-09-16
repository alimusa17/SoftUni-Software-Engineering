using System;

namespace _10._Profit
{
    class Program
    {
        static void Main(string[] args)
        {
            int coins1 = int.Parse(Console.ReadLine());
            int coins2 = int.Parse(Console.ReadLine());
            int coins5 = int.Parse(Console.ReadLine());
            int sum = int.Parse(Console.ReadLine());

            for (int i = 0; i <= coins1; i++)
            {
                for (int k = 0; k <= coins2; k++)
                {
                    for (int l = 0; l <= coins5; l++)
                    {
                        if ((i * 1) + (k * 2) + (l * 5) == sum)
                        {
                            Console.WriteLine($"{i} * 1 lv. + {k} * 2 lv. + {l} * 5 lv. = {sum} lv.");
                        }

                    }
                }
            }
        }
    }
}
