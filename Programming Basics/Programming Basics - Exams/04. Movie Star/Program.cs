using System;

namespace _04._Movie_Star
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());    //90000            //19999.5             //15999.6
            string command = Console.ReadLine();                 // Christian Bale; Leonardo DiCaprio    Kevin Spacey
            bool endOfBudget = false;

            while (command != "ACTION")
            {
                string actor = command;                         // Christian Bale ;  //Leonardo DiCaprio
                double salary = 0;                          //70000.50 oт конзолата                     //24000.99
                if (actor.Length <= 15)                         //не                 // да
                {
                    salary = double.Parse(Console.ReadLine());                       // прескачаме
                }
                else
                {
                    salary = budget * 0.2; //Името на втория актьор е по-дълго от 15 символа => 20% от 19999.5 = 3999.9       
                }

                budget -= salary;  //90000 - 70000.50 = 19999.5        19999.5 - 3999.9 = 15999.6 

                if (budget <= 0)                                                                  //15999.6 - 24000.99
                {
                    Console.WriteLine($"We need {Math.Abs(budget):f2} leva for our actors.");
                    endOfBudget = true;
                    break;
                }

                command = Console.ReadLine();
            }
            if (!endOfBudget)
            {
                Console.WriteLine($"We are left with {budget:F2} leva.");
            }


        }
    }
}
