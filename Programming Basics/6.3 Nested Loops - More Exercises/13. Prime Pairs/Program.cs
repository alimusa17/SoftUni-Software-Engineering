using System;

namespace _13._Prime_Pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNum1 = int.Parse(Console.ReadLine());
            int startNum2 = int.Parse(Console.ReadLine());
            int endNum1 = int.Parse(Console.ReadLine());
            int endNum2 = int.Parse(Console.ReadLine());

            for (int a = startNum1; a <= startNum1 + endNum1; a++)
            {
                for (int k = startNum2; k <= startNum2 + endNum2; k++)
                {
                    bool isPrime1 = true;
                    for (int i = 2; i <= Math.Sqrt(a); i++)
                    {
                        if (a % i == 0)
                        {
                            isPrime1 = false;
                        }
                    }
                    bool isPrime2 = true;
                    for (int i = 2; i <= Math.Sqrt(k); i++)
                    {
                        if (k % i == 0)
                        {
                            isPrime2 = false;
                        }
                    }
                    if (isPrime1 && isPrime2)
                    {
                        Console.WriteLine($"{a}{k}");
                    }
                }
            }

        }
    }
}
