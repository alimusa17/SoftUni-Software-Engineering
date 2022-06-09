using System;

namespace _05._Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
                        
            string destination = ""; 
            string type = "";        
            double price = 0.0;      

            if (budget <=100)
            {
                destination = "Bulgaria";
                if (season == "summer")
                {
                    type = "Camp";
                    price = budget * 0.3;
                }
                else
                {
                    type = "Hotel";
                    price = budget * 0.7;
                }
            }
            else if (budget <= 1000)
            {
                destination = "Balkans";
                if (season == "summer")
                {
                    type = "Camp";
                    price = budget * 0.4;
                }
                else
                {
                    type = "Hotel";
                    price = budget * 0.8;
                }
            }
            else                              
            {                                 
                destination = "Europe";       
                type = "Hotel";               
                price = budget * 0.9;         
            }                                 

            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{type} - {(price):f2}");
          
                            
                    

        }
    }
}
