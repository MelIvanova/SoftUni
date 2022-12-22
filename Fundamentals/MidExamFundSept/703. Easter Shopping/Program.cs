using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _703._Easter_Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> shops = Console.ReadLine().Split().ToList();
            int numberOfShops = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfShops; i++)
            {
                string input = Console.ReadLine();
                string[] arguments = input.Split();
                string command = arguments[0];

                switch (command)
                {
                    case "Include":
                        string shop = arguments[1];
                        shops.Add(shop);
                        break;
                    case "Visit":
                        string fromWhere = arguments[1];
                        int length = int.Parse(arguments[2]);
                        if (length>shops.Count)
                        {
                            continue;
                        }
                        if (fromWhere == "first")
                        {
                            shops.RemoveRange(0, length);
                        }
                        else
                        {
                            shops.RemoveRange(shops.Count - length, length);
                        }
                        break;
                    case "Prefer":
                        int firstIndex = int.Parse(arguments[1]);
                        int secondIndex =int.Parse(arguments[2]);
                        
                        if (firstIndex>=0 && secondIndex>=0 && firstIndex< shops.Count && secondIndex<shops.Count)
                        {
                            string current = shops[firstIndex];
                            shops[firstIndex] = shops[secondIndex];
                            shops[secondIndex] = current;
                        }
                        break;
                    case "Place":
                        string newShop = arguments[1];
                        int givenIndex = int.Parse(arguments[2])+1;
                        if (givenIndex>=0 && givenIndex < shops.Count)
                        {
                            shops.Insert(givenIndex, newShop);
                        }
                        break;
                }
            }
            Console.WriteLine("Shops left:");
            Console.WriteLine(string.Join(" ", shops));
        }
    }
}
