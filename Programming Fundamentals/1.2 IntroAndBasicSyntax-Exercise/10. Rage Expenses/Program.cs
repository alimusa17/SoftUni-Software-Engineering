using System;

namespace _10._Rage_Expenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGamesCount = int.Parse(Console.ReadLine());

            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keybordPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            int trashedHeadset = lostGamesCount / 2;
            int trashedMouse = lostGamesCount / 3;
            int trashedKeyboard = trashedMouse / 2;
            int trashedDisplay = trashedKeyboard / 2;

            double expenses = headsetPrice * trashedHeadset + mousePrice * trashedMouse + keybordPrice * trashedKeyboard + displayPrice * trashedDisplay;

            Console.WriteLine($"Rage expenses: {expenses:F2} lv.");
        }
    }
}
