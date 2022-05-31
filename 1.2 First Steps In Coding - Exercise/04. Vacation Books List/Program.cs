using System;

namespace _04._Vacation_Books_List
{
    class Program
    {
        static void Main(string[] args)
        {
            int pageofbook = int.Parse(Console.ReadLine());
            int pageforhour = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            int totalhours = pageofbook / pageforhour;
            int hoursperday = totalhours / days;

            Console.WriteLine(hoursperday);

        }
    }
}
