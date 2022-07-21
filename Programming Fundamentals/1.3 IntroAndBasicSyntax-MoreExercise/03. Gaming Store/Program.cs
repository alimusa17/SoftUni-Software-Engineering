using System;

namespace _03._Gaming_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            double currentBalance = double.Parse(Console.ReadLine());
            string gameName = string.Empty;                  
            double spendMoney = 0;

            while ((gameName = Console.ReadLine()) != "Game Time")
            {
                if (gameName == "OutFall 4")
                {
                    if (currentBalance >= 39.99)
                    {
                        currentBalance -= 39.99;
                        spendMoney += 39.99;
                        Console.WriteLine($"Bought {gameName}");
                    }

                    else
                    {
                        Console.WriteLine("Too Expensive");
                        continue;
                    }
                }

                else if (gameName == "CS: OG")
                {
                    if (currentBalance >= 15.99)
                    {
                        currentBalance -= 15.99;
                        spendMoney += 15.99;
                        Console.WriteLine($"Bought {gameName}");
                    }

                    else
                    {
                        Console.WriteLine("Too Expensive");
                        continue;
                    }
                }

                else if (gameName == "Zplinter Zell")
                {
                    if (currentBalance >= 19.99)
                    {
                        currentBalance -= 19.99;
                        spendMoney += 19.99;
                        Console.WriteLine($"Bought {gameName}");
                    }

                    else
                    {
                        Console.WriteLine("Too Expensive");
                        continue;
                    }
                }

                else if (gameName == "Honored 2")
                {
                    if (currentBalance >= 59.99)
                    {
                        currentBalance -= 59.99;
                        spendMoney += 59.99;
                        Console.WriteLine($"Bought {gameName}");
                    }

                    else
                    {
                        Console.WriteLine("Too Expensive");
                        continue;
                    }
                }

                else if (gameName == "RoverWatch")
                {
                    if (currentBalance >= 29.99)
                    {
                        currentBalance -= 29.99;
                        spendMoney += 29.99;
                        Console.WriteLine($"Bought {gameName}");
                    }

                    else
                    {
                        Console.WriteLine("Too Expensive");
                        continue;
                    }
                }

                else if (gameName == "RoverWatch Origins Edition")
                {
                    if (currentBalance >= 39.99)
                    {
                        currentBalance -= 39.99;
                        spendMoney += 39.99;
                        Console.WriteLine($"Bought {gameName}");
                    }

                    else
                    {
                        Console.WriteLine("Too Expensive");
                        continue;
                    }
                }


                else
                {
                    Console.WriteLine("Not found");
                }

                if (currentBalance <= 0)
                {
                    Console.WriteLine("Out of money!");
                    return;
                }
            }

            Console.WriteLine($"Total spent: ${spendMoney:f2}. Remaining: ${currentBalance:f2}");
        }
    }
}
