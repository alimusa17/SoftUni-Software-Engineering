using System;

namespace _04._Renovation
{
    class Program
    {
        static void Main(string[] args)
        {
            int height = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int percent = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            //double remains = 0;

            //int litersPaint = int.Parse(Console.ReadLine());

            //double area = height * width * 4;
            //double allWalls = area - area * percent;

            while (command != "Tired!")
            {
                int litersPaint = int.Parse(Console.ReadLine());
                double area = height * width * 4;
                double allWalls = area - area * percent;

                double painting = allWalls - litersPaint;

            }

            




        }
    }
}
