using System;
using System.Collections.Generic;
using System.Text;

namespace _05._Multiply_Big_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string reallyBigNum = Console.ReadLine();
            int num = int.Parse(Console.ReadLine());

            //1234
            //  *5
            //6170

            if (num == 0)
            {
                Console.WriteLine(0);
                return;
            }

            StringBuilder sb = new StringBuilder();
            int remainder = 0;

            for (int i = reallyBigNum.Length - 1; i >= 0; i--)
            {
                char lastNum = reallyBigNum[i];
                int lastNumAsDigit = int.Parse(lastNum.ToString());

                int result = lastNumAsDigit * num + remainder;

                sb.Append(result % 10);

                remainder = result / 10;
            }

            if (remainder != 0)
            {
                sb.Append(remainder);
            }

            StringBuilder reservedString = new StringBuilder();

            for (int i = sb.Length - 1; i >= 0; i--)
            {
                reservedString.Append(sb[i]);
            }

            Console.WriteLine(reservedString);
        }
    }
}
