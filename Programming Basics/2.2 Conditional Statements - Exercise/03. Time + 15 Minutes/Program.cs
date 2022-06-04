using System;

namespace _03._Time___15_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine()); //1
            int m = int.Parse(Console.ReadLine()); //30

            int timeInMin = m + h * 60; //30+1*60 = 90min
            timeInMin = timeInMin + 15; //90+15 = 105min

            h = timeInMin / 60; //105/60 = 1 (45)
            m = timeInMin % 60; //105%60 = 45

            if (h >= 24)
            {
                h = 0;    //h - 24 // 24-24=0
            }
            if (m < 10)
            {
                Console.WriteLine($"{h}:0{m}");
            }
            else
            {
                Console.WriteLine($"{h}:{m}");
            }

        }
    }
}
