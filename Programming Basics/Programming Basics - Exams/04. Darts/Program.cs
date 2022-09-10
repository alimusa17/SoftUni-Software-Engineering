using System;

namespace _04._Darts
{
    class Program
    {
        static void Main(string[] args)
        {
            //string player = Console.ReadLine();
            //string input = Console.ReadLine();                       //field?        //поле single, double, triple,
            //int points = int.Parse(Console.ReadLine());     
            //int totalPoints = 301; //301 по условие

            // while (input != "Retire")
            // {
            //
            // }

            string name = Console.ReadLine();                       //името на играча => после преобразуваме в string
            int totalPoints = 301;                                  //по задание 
            int successfulShots = 0;                                //запазваме
            int unSuccessfulShots = 0;                              //запазваме

            while (totalPoints != 0)                                //
            {
                string area = Console.ReadLine();      //string ни е променлива изпозлваме за име и команда area
                if (area == "Retire")                 //докато получим командата ще продължи програмата
                {
                    break;
                }

                int points = int.Parse(Console.ReadLine());//точките идват като ги Parse нем от конзолата ако са число

                if (area == "Triple")  //ако са думи влизат в този цикъл
                {
                    points *= 3;
                }
                else if (area == "Double")
                {
                    points *= 2;
                }

                if (totalPoints - points >= 0) //условието дали е вярно
                {
                    totalPoints -= points;     //301- точките
                    successfulShots++;         // брояч
                }
                else
                {
                    unSuccessfulShots++;       // брояч
                }
            }

            if (totalPoints == 0)
            {
                Console.WriteLine($"{name} won the leg with {successfulShots} shots.");
            }
            else
            {
                Console.WriteLine($"{name} retired after {unSuccessfulShots} unsuccessful shots.");
            }

        }
    }
}
