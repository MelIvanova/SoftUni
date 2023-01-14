using System;
using System.Collections.Generic;

namespace E06._Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                string[] information = Console.ReadLine().Split(" -> ");
                string colors = information[0];
                string[] clothes = information[1].Split(',');

                if (!wardrobe.ContainsKey(colors))
                {
                    wardrobe[colors] = new Dictionary<string, int>();
                }
                for (int j = 0; j < clothes.Length; j++)
                {
                    if (!wardrobe[colors].ContainsKey(clothes[j]))
                    {
                        wardrobe[colors][clothes[j]] = 0;
                    }
                    wardrobe[colors][clothes[j]]++;
                }
                
            }

            string[] search = Console.ReadLine().Split();
            string color = search[0];
            string cloth = search[1];

            foreach (var element in wardrobe)
            {
                Console.WriteLine($"{element.Key} clothes:");

                foreach (var clothes in element.Value)
                {
                    if (element.Key == color && clothes.Key == cloth)
                    {
                        Console.WriteLine($"* {clothes.Key} - {clothes.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {clothes.Key} - {clothes.Value}");
                    }
                }
            }
        }
    }
}
