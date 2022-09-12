using System;

namespace _02._Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            int period = int.Parse(Console.ReadLine());

            int doctors = 7;
            int treatedPatients = 0;
            int unTreatedPatients = 0;

            for (int days = 1; days <= period; days++)
            {
                int patients = int.Parse(Console.ReadLine());

                if (days % 3 == 0 && unTreatedPatients > treatedPatients)
                {
                    doctors++;
                }

                if (patients >= doctors)
                {
                    treatedPatients += doctors;
                    unTreatedPatients += patients - doctors;
                }
                else
                {
                    treatedPatients += patients;
                }
            }

            Console.WriteLine($"Treated patients: {treatedPatients}.");
            Console.WriteLine($"Untreated patients: {unTreatedPatients}.");

        }
    }
}
