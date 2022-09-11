using System;

namespace _06._Barcode_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            //aаo имеме четирицифрено число по този начин отделяме всяка една от цифрите му
            //ако числото е num=2345


            //int d4 =num % 10; //=> (4)
            //int d3 =num / 10 % 10;//=> (3)
            //int d2 =num / 100 % 10; //=> (2)
            //int d1 =num / 1000; //=> (1)

            int first = int.Parse(Console.ReadLine()); // d1 d2 d3 d4 //1234
            int second = int.Parse(Console.ReadLine()); // d1 d2 d3 d4 //4567
                                                        // d1 => 1, 3,
                                                        // d2 => 3, 5
                                                        // d3 => 3, 5,
                                                        // d4 => 5, 7


            for (int d1 = first / 1000; d1 <= second / 1000; d1++)
            {
                if (d1 % 2 == 0) //d1 = 2
                {
                    continue;
                }
                for (int d2 = first / 100 % 10; d2 <= second / 100 % 10; d2++)
                {
                    if (d2 % 2 == 0)
                    {
                        continue;
                    }
                    for (int d3 = first / 10 % 10; d3 <= second / 10 % 10; d3++)
                    {
                        if (d3 % 2 == 0)
                        {
                            continue;
                        }
                        for (int d4 = first % 10; d4 <= second % 10; d4++)
                        {
                            if (d4 % 2 == 0)
                            {
                                continue;
                            }

                            Console.Write($"{d1}{d2}{d3}{d4} ");
                        }
                    }
                }
            }
        }
    }
}
