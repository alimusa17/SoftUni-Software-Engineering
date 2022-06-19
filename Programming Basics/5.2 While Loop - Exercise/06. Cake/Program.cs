using System;

namespace _06._Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int piecesCount = width * length;
            string piecesTaken = Console.ReadLine();

            while (piecesTaken != "STOP")
            {
                int piecesNumber = int.Parse(piecesTaken);
                piecesCount -= piecesNumber;
                if (piecesCount < 0)
                {
                    Console.WriteLine($"No more cake left! You need {Math.Abs(piecesCount)} pieces more.");
                    return;
                }
                piecesTaken = Console.ReadLine();
            }

            Console.WriteLine($"{piecesCount} pieces are left.");
        }
    }
}
