using System;

namespace _04._Sequence_2k_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int kNumber = 0;

            while (kNumber < number)
            {
                kNumber = kNumber * 2 + 1;
                if (kNumber <= number)
                {
                    Console.WriteLine(kNumber);
                }
            }

        }
    }
}
