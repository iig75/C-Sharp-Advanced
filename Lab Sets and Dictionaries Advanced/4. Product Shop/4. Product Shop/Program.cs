using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._Product_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, double>> shops = new Dictionary<string, Dictionary<string, double>>();

            while(true)
            {
                string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

                if (input[0] == "Revision")
                    break;

                string shop = input[0];
                string product = input[1];
                double price = double.Parse(input[2]);

                if(!shops.ContainsKey(shop))
                {
                    shops.Add(shop, new Dictionary<string, double>());
                    shops[shop].Add(product, price);
                }
                else
                {
                    shops[shop].Add(product, price);
                }
            }

            foreach(var shop in shops.OrderBy(x=>x.Key))
            {
                Console.WriteLine($"{shop.Key}->");
                
                foreach (var product in shop.Value)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
                }

            }
        }
    }
}
