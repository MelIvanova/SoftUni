using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

namespace _03._Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {
           
            
            Dictionary<string, int> qestRequires = new Dictionary<string, int>();
            qestRequires.Add("motes", 0);
            qestRequires.Add("shards", 0);
            qestRequires.Add("fragments", 0);
            SortedDictionary<string, int> junk = new SortedDictionary<string, int>();
            bool leave = true;
            while (leave)
            {
                
                List<string> input = Console.ReadLine().Split().ToList();

                for (int i = 0; i < input.Count ; i+=2)
                {
                    int quantity = int.Parse(input[i]);
                    string material = input[i + 1].ToLower();
                    if (material == "motes"|| material == "shards"|| material == "fragments")
                    {
                        qestRequires[material] += quantity;
                        if (qestRequires[material] >= 250)
                        {
                            switch (material)
                            {
                                case "motes":
                                    Console.WriteLine("Dragonwrath obtained!");
                                    break;
                                case "shards":
                                    Console.WriteLine("Shadowmourne obtained!");
                                    break;
                                case "fragments":
                                    Console.WriteLine("Valanyr obtained!");
                                    break;
                            }
                            leave = false;
                            qestRequires[material] -= 250;
                            break;
                        }
                    }
                    else
                    {
                        if (!junk.ContainsKey(material))
                        {
                            junk.Add(material, quantity);
                        }
                        else
                        {
                            junk[material] += quantity;
                        }
                    }
                   

                }
            }
            
            var orderd = qestRequires.OrderByDescending(v => v.Value).ThenBy(k => k.Key);

            foreach (var kvp in orderd)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
            foreach (var kvp in junk)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
        }
    }
}
