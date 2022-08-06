using System;
using System.Linq;
using System.Collections.Generic;

namespace _05._Remove_Negatives_and_Reverse_V2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            
            numbers.RemoveAll(number => number < 0);
            numbers.RemoveAll(number => number >= 0);
            numbers.RemoveAll(number => number % 2 == 0);
            
            numbers.Reverse();
            
            if (numbers.Count > 0)
            {
                Console.WriteLine(string.Join(" ", numbers));
            
                return;
            }
            
            Console.WriteLine("empty");
        }
    }
}
