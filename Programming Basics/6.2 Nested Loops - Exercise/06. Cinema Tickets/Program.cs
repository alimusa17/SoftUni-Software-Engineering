using System;

namespace _06._Cinema_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            string comand = Console.ReadLine();
            int totalStudents = 0;
            int totalStandards = 0;
            int totalKids = 0;
            int totalTickets = 0;

            while (comand != "Finish")
            {
                int students = 0;
                int standard = 0;
                int kid = 0;

                int freeSpots = int.Parse(Console.ReadLine());

                for (int i = 0; i < freeSpots; i++)
                {
                    string ticketType = Console.ReadLine();
                    if (ticketType == "End")
                    {
                        break;
                    }
                    switch (ticketType)
                    {
                        case "student":
                            students++;
                            break;
                        case "standard":
                            standard++;
                            break;
                        case "kid":
                            kid++;
                            break;
                    }
                }
                totalStudents += students;
                totalStandards += standard;
                totalKids += kid;
                double percentageFull = (students + standard + kid) / (double)freeSpots * 100;
                Console.WriteLine($"{comand} - {percentageFull:f2}% full.");

                comand = Console.ReadLine();
            }

            totalTickets = totalStudents + totalStandards + totalKids;

            Console.WriteLine($"Total tickets: {totalTickets}");

            double standardPercentage = totalStandards / (double) totalTickets * 100;
            double studentsPercentage = totalStudents / (double) totalTickets * 100;
            double kidsPercentage = totalKids / (double) totalTickets * 100;

            Console.WriteLine($"{studentsPercentage:f2}% student tickets.");
            Console.WriteLine($"{standardPercentage:F2}% standard tickets.");
            Console.WriteLine($"{kidsPercentage:f2}% kids tickets.");
        }
    }
}
