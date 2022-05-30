using System;

namespace _07._Projects_Creation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = (Console.ReadLine());
            int project = int.Parse(Console.ReadLine());

            double hours = project * 3;

            Console.WriteLine($"The architect {name} will need {hours} hours to complete {project} project/s. ");
        }
    }
}
