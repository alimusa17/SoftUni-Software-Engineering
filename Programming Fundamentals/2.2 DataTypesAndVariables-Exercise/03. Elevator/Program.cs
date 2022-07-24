using System;

namespace _03._Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int persons = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            double withReminderCourses = (double)persons / capacity;

            Console.WriteLine(Math.Ceiling(withReminderCourses));
        }
    }
}
