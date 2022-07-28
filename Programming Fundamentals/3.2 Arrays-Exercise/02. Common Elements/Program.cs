using System;

namespace _02._Common_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrayOne = Console.ReadLine().Split(' ');
            string[] arrayTwo = Console.ReadLine().Split(' ');

            foreach (string currentElement in arrayOne)
            {
                for (int i = 0; i < arrayTwo.Length; i++)
                {
                    string secondCurrentElement = arrayTwo[i];
                    if (currentElement == secondCurrentElement)
                    {
                        Console.Write($"{currentElement} ");
                        break;
                    }
                }
            }
        }
    }
}
