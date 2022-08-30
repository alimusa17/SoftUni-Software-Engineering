using System;

namespace _07.House_Painting
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double wallSideArea = x * y;
            double windowArea = 1.5 * 1.5;
            double wallSides = 2 * wallSideArea - 2 * windowArea;

            double wallBackendArea = x * x;
            double entry = 1.2 * 2;
            double wallBackend = 2 * wallBackendArea - entry;

            double totalWallArea = wallSides + wallBackend;

            double greenPaint = totalWallArea / 3.4;

            double rectangles = 2 * (x * y);
            double triangles = 2 * (x * h / 2);

            double totalRoofArea = rectangles + triangles;

            double redPaint = totalRoofArea / 4.3;

            Console.WriteLine($"{greenPaint:F2}");
            Console.WriteLine($"{redPaint:F2}");
        }
    }
}
