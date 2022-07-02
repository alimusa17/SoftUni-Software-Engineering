using System;

namespace _04._Movie_Star
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());  
            string command = Console.ReadLine();               
            bool endOfBudget = false;

            while (command != "ACTION")
            {
                string actor = command;                        
                double salary = 0;                             
                if (actor.Length <= 15)                        
                {
                    salary = double.Parse(Console.ReadLine());                              
                }
                else
                {
                    salary = budget * 0.2;                                                      
                }

                budget -= salary;                                                           

                if (budget <= 0)                                                            
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
