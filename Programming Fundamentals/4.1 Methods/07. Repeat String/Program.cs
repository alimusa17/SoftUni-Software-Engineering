using System;
using System.Text;
using System.Linq;

namespace _07._Repeat_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int times = int.Parse(Console.ReadLine());

            Console.WriteLine(RepeatString(input, times));
        }

        private static string RepeatString(string str, int count)
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < count; i++)
            {
                //result.Append(str);
            }

            return result.ToString();

        }
    }
}
