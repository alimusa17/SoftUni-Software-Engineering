using System;

namespace _07._Trekking_Mania
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupsOfPeoples = int.Parse(Console.ReadLine());

            int groupe1 = 0;
            int groupe2 = 0;
            int groupe3 = 0;
            int groupe4 = 0;
            int groupe5 = 0;

            for (int i = 1; i <= groupsOfPeoples; i++)
            {
                int climbersCount = int.Parse(Console.ReadLine());
                if (climbersCount < 6)
                {
                    groupe1 += climbersCount;
                }
                else if (climbersCount < 13)
                {
                    groupe2 += climbersCount;
                }
                else if (climbersCount < 26)
                {
                    groupe3 += climbersCount;
                }
                else if (climbersCount < 41)
                {
                    groupe4 += climbersCount;
                }
                else
                {
                    groupe5 += climbersCount;
                }
            }

            int totalClimbersCount = groupe1 + groupe2 + groupe3 + groupe4 + groupe5;

            double convertGroupe1 = 1.0 * groupe1 / totalClimbersCount * 100;
            double convertGroupe2 = 1.0 * groupe2 / totalClimbersCount * 100;
            double convertGroupe3 = 1.0 * groupe3 / totalClimbersCount * 100;
            double convertGroupe4 = 1.0 * groupe4 / totalClimbersCount * 100;
            double convertGroupe5 = 1.0 * groupe5 / totalClimbersCount * 100;

            Console.WriteLine($"{convertGroupe1:f2}%");
            Console.WriteLine($"{convertGroupe2:f2}%");
            Console.WriteLine($"{convertGroupe3:f2}%");
            Console.WriteLine($"{convertGroupe4:f2}%");
            Console.WriteLine($"{convertGroupe5:f2}%");
        }
    }
}
