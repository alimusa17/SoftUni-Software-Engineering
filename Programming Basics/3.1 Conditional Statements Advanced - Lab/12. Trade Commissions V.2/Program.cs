﻿using System;

namespace _12._Trade_commisions
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine().ToLower();
            double sales = double.Parse(Console.ReadLine());

            var comission = 0.0;

            if (city == "sofia")
            {
                if (sales >= 0 && sales <= 500)
                {
                    comission = 0.05;
                    Console.WriteLine("{0:f2}", sales * comission);
                }
                else if (sales > 500 && sales <= 1000)
                {
                    comission = 0.07;
                    Console.WriteLine("{0:f2}", sales * comission);
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    comission = 0.08;
                    Console.WriteLine("{0:f2}", sales * comission);
                }
                else if (sales > 10000)
                {
                    comission = 0.12;
                    Console.WriteLine("{0:f2}", sales * comission);
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (city == "varna")
            {
                if (sales >= 0 && sales <= 500)
                {
                    comission = 0.045;
                    Console.WriteLine("{0:f2}", sales * comission);
                }
                else if (sales > 500 && sales <= 1000)
                {
                    comission = 0.075;
                    Console.WriteLine("{0:f2}", sales * comission);
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    comission = 0.10;
                    Console.WriteLine("{0:f2}", sales * comission);
                }
                else if (sales > 10000)
                {
                    comission = 0.13;
                    Console.WriteLine("{0:f2}", sales * comission);
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (city == "plovdiv")
            {
                if (sales >= 0 && sales <= 500)
                {
                    comission = 0.055;
                    Console.WriteLine("{0:f2}", sales * comission);
                }
                else if (sales > 500 && sales <= 1000)
                {
                    comission = 0.08;
                    Console.WriteLine("{0:f2}", sales * comission);
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    comission = 0.12;
                    Console.WriteLine("{0:f2}", sales * comission);
                }
                else if (sales > 10000)
                {
                    comission = 0.145;
                    Console.WriteLine("{0:f2}", sales * comission);
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
