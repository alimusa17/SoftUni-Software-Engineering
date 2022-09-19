using System;

namespace _06._Multiply_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int num1 = n % 10;
            int num2 = n / 10 % 10;
            int num3 = n / 100;

            for (int i = 1; i <= num1; i++)
            {
                for (int j = 1; j <= num2; j++)
                {
                    for (int k = 1; k <= num3; k++)
                    {
                        double result = (i * j * k);
                        Console.WriteLine($"{i}*{j}*{k} = {result}");
                    }

                }

            }

        }
    }
}
