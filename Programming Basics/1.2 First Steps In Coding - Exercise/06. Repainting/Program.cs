using System;

namespace _06._Repainting
{
    class Program
    {
        static void Main(string[] args)
        {
            int nylonQuantity = int.Parse(Console.ReadLine());
            int paintQuantity = int.Parse(Console.ReadLine());
            int thinnerQuantity = int.Parse(Console.ReadLine());
            int workersHours = int.Parse(Console.ReadLine());

            double nylonPrice = (nylonQuantity + 2) * 1.5;
            double paintPrice = (paintQuantity + paintQuantity * 0.1) * 14.5;
            double thinnerPrice = thinnerQuantity * 5;

            // Alternative Debug ;)
            //Console.WriteLine($"nylonPrice: {nylonPrice} + paintPrice: {paintPrice} + thinnerPrice: {thinnerPrice}");

            double materialsum = nylonPrice + paintPrice + thinnerPrice + 0.4;

            //Console.WriteLine("materialsum:" + materialsum);

            double workerssum = (materialsum * 0.3) * workersHours;
            //Console.WriteLine("workerssum" + workerssum);

            double totalsum = materialsum + workerssum;

            //Console.WriteLine("totalsum" + totalsum);
            Console.WriteLine(totalsum);

        }
    }
}
