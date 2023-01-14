using System;
using System.Collections.Generic;
using System.Linq;

namespace A03._Product_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, Dictionary<string, double>> shopsProducts =
                new SortedDictionary<string, Dictionary<string, double>>();
            string[] information = Console.ReadLine().Split(", ");
            string shop = information[0];

            while (shop != "Revision")
            {
                string product = information[1];
                double price = double.Parse(information[2]);

                if (!shopsProducts.ContainsKey(shop))
                {
                    shopsProducts.Add(shop, new Dictionary<string, double>()); ;
                }
                if (!shopsProducts[shop].ContainsKey(product))
                {
                    shopsProducts[shop].Add(product, price);
                }


                information = Console.ReadLine().Split(", ");
                shop = information[0];
            }

            foreach (var shops in shopsProducts)
            {
                Console.WriteLine($"{shops.Key}->");

                foreach (var product in shops.Value)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
                }
            }
        }
    }
}
