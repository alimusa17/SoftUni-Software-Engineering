using System;

namespace _01._Old_Books
{
    class Program
    {
        static void Main(string[] args)
        {
            string favouriteBook = Console.ReadLine();

            int count = 0;
            string input = Console.ReadLine();

            while (input != "No More Books")
            {
                if (input == favouriteBook)
                {
                    break;
                }
                count++;
                input = Console.ReadLine();
            }
            if (input == favouriteBook)
            {
                Console.WriteLine($"You checked {count} books and found it.");
            }
            else
            {
                Console.WriteLine($"The book you search is not here!");
                Console.WriteLine($"You checked {count} books.");
            }
        }
    }
}
