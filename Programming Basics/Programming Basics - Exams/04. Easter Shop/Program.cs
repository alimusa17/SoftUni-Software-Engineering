using System;

namespace _04._Easter_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            int eggsCount = int.Parse(Console.ReadLine()); //начално к-во налични
            int soldEggs = 0;                             //създаваме променлива за продадени яйца

            string command = Console.ReadLine();  //СЪЗДАВАМЕ    //След това поредица от два реда - == buy; + == fill
                                                  //ПРОМЕНЛИВА   //След това поредица от два реда и числа int

            while (command != "Close")            //докато получим команда Close
            {
                if (command == "Fill")           //ако е Fill добавяме
                {
                    int toFill = int.Parse(Console.ReadLine());    //колко добавяме от конзолата
                    eggsCount += toFill;                           //добавяме към наличните и ги запазим 
                }
                if (command == "Buy")         //ако е Buy намаляват
                {
                    int count = int.Parse(Console.ReadLine());
                    if (count < eggsCount)
                    {
                        eggsCount -= count;                         //останали яйца - продадени
                        soldEggs += count;                          //запазваме продадените яйца
                    }
                    else                                            //Ако са свършили
                    {
                        Console.WriteLine("Not enough eggs in store!");
                        Console.WriteLine($"You can buy only {eggsCount}.");  // колко са налични
                    }
                }
                command = Console.ReadLine();
            }
            if (command == "Close")
            {
                Console.WriteLine("Store is closed!");
                Console.WriteLine($"{soldEggs} eggs sold.");                    //общо продадени яйца
            }
        }
    }
}
