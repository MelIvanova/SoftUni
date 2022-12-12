using System;
using System.Collections.Generic;

namespace _04._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string token = Console.ReadLine();
            string[] input = token.Split();
            Dictionary<string, double> productsPrice = new Dictionary<string, double>();
            Dictionary<string, int> productsQuantiti = new Dictionary<string, int>();

            while (token != "buy")
            {

                    double price = double.Parse(input[1]);
                    int quantity = int.Parse(input[2]);
                    if (!productsPrice.ContainsKey(input[0]))
                    {
                        
                        productsPrice.Add(input[0], price);
                        productsQuantiti.Add(input[0], quantity);
                    }
                    else 
                    {
                        productsQuantiti[input[0]] += quantity;

                        productsPrice[input[0]] = price;
                    }
                    
                token = Console.ReadLine();
                if (token.Length==3)
                {
                    continue;
                }
                input = token.Split();
               
            }

            foreach (var item in productsQuantiti)
            {
                double totalPtice = 0;
                if (productsPrice.ContainsKey(item.Key))
                {
                    totalPtice = item.Value * productsPrice[item.Key];
                }
                Console.WriteLine($"{item.Key} -> {totalPtice:F2}");
            }
        }
    }
}
