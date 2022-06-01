using System;

namespace _07._Food_Delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int chikenCount = int.Parse(Console.ReadLine());
            int fishCount = int.Parse(Console.ReadLine());
            int veganCount = int.Parse(Console.ReadLine());

            double chikenPrice = chikenCount * 10.35;
            double fishPrice = fishCount * 12.40;
            double veganPrice = veganCount * 8.15;

            double menusum = chikenPrice + fishPrice + veganPrice;

            double desert = menusum * 0.20; //20%

            //double delivery = 2.5;

            double totalsum = menusum + desert + 2.5 ;

            Console.WriteLine(totalsum);

        }
    }
}
