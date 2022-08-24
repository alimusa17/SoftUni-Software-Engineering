using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _01._Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            // step 1 find the REGEX

            string regex = @">>(?<name>[A-Za-z\s]+)<<(?<price>\d+(.\d+)?)!(?<quantity>\d+)";

            // step 2 read the input from the console
            string input = Console.ReadLine();

            // step 3 create a list of the items or so called names of all furnitures
            var list = new List<string>();

            //step 4 create variable for the total price
            double totalPrice = 0;

            //step 5 Creating while loop to get throughout every input until command Purchase
            while (input != "Purchase")
            {
                Match matches = Regex.Match(input, regex, RegexOptions.IgnoreCase);

                if (matches.Success)
                {
                    var name = matches.Groups["name"].Value;
                    var price = double.Parse(matches.Groups["price"].Value);
                    var quantity = int.Parse(matches.Groups["quantity"].Value);
                    list.Add(name);
                    totalPrice += price * quantity;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("Bought furniture:");
            list.ForEach(Console.WriteLine);
            Console.WriteLine($"Total money spend: {totalPrice:F2}");
        }
    }
}
