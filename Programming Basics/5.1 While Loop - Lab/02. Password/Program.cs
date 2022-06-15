using System;

namespace _02._Password
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = Console.ReadLine();

            int counter = 0;

            string passwordAttempt = Console.ReadLine();

            while (passwordAttempt != password)
            {
                counter++;
                if (counter == 3)
                {
                    break;
                }
                passwordAttempt = Console.ReadLine();
            }
            Console.WriteLine($"Welcome {username}!");
        }
    }
}
