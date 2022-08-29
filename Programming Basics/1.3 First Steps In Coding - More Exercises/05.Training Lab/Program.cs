using System;

namespace _05.Training_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            //double limits = 3 ≤ h ≤ w ≤ 100.

            double deskInARow = (height - 1) / 0.7;
            double places = width / 1.2;

            double heightCentimeters = Math.Round(deskInARow, 0);
            double widthCentimeters = Math.Round(places, 0);

            Console.WriteLine(widthCentimeters * heightCentimeters - 3);
        }
    }
}
