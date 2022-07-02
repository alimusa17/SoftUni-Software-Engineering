using System;

namespace _04._Easter_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            int eggsCount = int.Parse(Console.ReadLine());
            int soldEggs = 0;                             

            string command = Console.ReadLine();          
                                                          

            while (command != "Close")                    
            {
                if (command == "Fill")                  
                {
                    int toFill = int.Parse(Console.ReadLine());   
                    eggsCount += toFill;                          
                }
                if (command == "Buy")                             
                {
                    int count = int.Parse(Console.ReadLine());
                    if (count < eggsCount)
                    {
                        eggsCount -= count;                        
                        soldEggs += count;                         
                    }
                    else                                           
                    {
                        Console.WriteLine("Not enough eggs in store!");
                        Console.WriteLine($"You can buy only {eggsCount}.");  
                    }
                }
                command = Console.ReadLine();
            }
            if (command == "Close")
            {
                Console.WriteLine("Store is closed!");
                Console.WriteLine($"{soldEggs} eggs sold.");                    
            }
        }
    }
}
