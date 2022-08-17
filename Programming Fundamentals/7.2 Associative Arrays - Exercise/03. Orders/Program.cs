﻿using System;
using System.ComponentModel.Design;
using System.Collections.Generic;

namespace _03._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2 dictionaries
            // 1 key nameOfTheProduct: value priceOfTheProduct
            // 2 key nameOfTheProduct: value quantityOfTheProduct

            var orders = new Dictionary<string, double>();
            var newOrders = new Dictionary<string, int>();

            var input = Console.ReadLine();

            while (input != "buy")
            {
                var cmd = input.Split();
                var productName = cmd[0];
                double productPrice = double.Parse(cmd[1]);
                int quantity = int.Parse(cmd[2]);

                if (!orders.ContainsKey(productName))
                {
                    orders.Add(productName, productPrice);
                    newOrders.Add(productName, quantity);
                }
                else if (orders.ContainsKey(productName))
                {
                    orders.Remove(productName);
                    orders.Add(productName, productPrice);
                    newOrders[productName] += quantity;
                }

                input = Console.ReadLine();
            }

            foreach (var order in orders)
            {
                foreach (var newOrder in newOrders)
                {
                    if (order.Key == newOrder.Key)
                    {
                        Console.WriteLine($"{order.Key} -> {order.Value * newOrder.Value:f2}");
                    }
                }
            }
        }
    }
}
