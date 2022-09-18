using System;

namespace _02._Football_Kit
{
    class Program
    {
        static void Main(string[] args)
        {
            double tshirtPrice = double.Parse(Console.ReadLine());
            double sum = double.Parse(Console.ReadLine());

            double shortPrice = tshirtPrice * 0.75;
            double socksPrice = shortPrice * 0.20;
            double shoesPrice = (tshirtPrice + shortPrice) * 2;

            double totalPrice = (tshirtPrice + shortPrice + socksPrice + shoesPrice);
            double discount = totalPrice * 0.15;
            double discountPrice = totalPrice - discount;

            double neededMoney = (sum - discountPrice);

            if (discountPrice >= sum)
            {
                Console.WriteLine("Yes, he will earn the world-cup replica ball!");
                Console.WriteLine($"His sum is {(discountPrice):f2} lv.");
            }
            else
            {
                Console.WriteLine("No, he will not earn the world-cup replica ball.");
                Console.WriteLine($"He needs {neededMoney:f2} lv. more.");
            }

        }
    }
}
