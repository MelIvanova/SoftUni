using System;
using System.Collections.Generic;

namespace _04._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> priceOfProduct = new Dictionary<string, double>();
            Dictionary<string, int> quantityOfProducts = new Dictionary<string, int>();
            string input = Console.ReadLine();

            while (input!= "buy")
            {
                string[] tokens = input.Split();
                string item = tokens[0];
                double price = double.Parse(tokens[1]);
                int quantity = int.Parse(tokens[2]);
                if (!priceOfProduct.ContainsKey(item))
                {
                    priceOfProduct.Add(item, price);
                    quantityOfProducts.Add(item, quantity);
                }
                else
                {
                    quantityOfProducts[item] += quantity;
                    priceOfProduct[item] = price;
                }
                input = Console.ReadLine();
            }
            double total = 0.0;
            foreach (var kvp in priceOfProduct)
            {
                total = kvp.Value * quantityOfProducts[kvp.Key];
                Console.WriteLine($"{kvp.Key} -> {total:F2}");
            }
        }
    }
}
