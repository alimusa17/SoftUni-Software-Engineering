using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._The_Lift
{
    class Program
    {
        static void Main(string[] args)
        {
            int peopleWaiting = int.Parse(Console.ReadLine());
            List<int> lift = Console.ReadLine().Split().Select(int.Parse).ToList();
            //int[] lift = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int maxPeoplePerWagon = 4;

            //for (int i = 0; i < lift.Length; i++)
            for (int i = 0; i < lift.Count; i++)
            {
                //for (int j = 0; j < maxPeoplePerWagon; j++)
                for (int j = lift[i]; j < maxPeoplePerWagon; j++)
                {
                    lift[i]++;
                    peopleWaiting--;

                    if (peopleWaiting == 0)
                    {
                        if (lift.Sum() < lift.Count * maxPeoplePerWagon)
                        {
                            Console.WriteLine($"The lift has empty spots!");
                        }
                        Console.WriteLine(string.Join(' ', lift));

                        return;
                    }
                }
            }

            Console.WriteLine($"There isn't enough space! {peopleWaiting} people in a queue!");
            Console.WriteLine(string.Join(' ', lift));
        }
    }
}
