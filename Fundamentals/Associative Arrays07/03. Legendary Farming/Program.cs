using System;
using System.Collections.Generic;
using System.Linq;


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

                for (int i = 0; i < input.Count; i += 2)
                {
                    int quantity = int.Parse(input[i]);
                    string material = input[i + 1].ToLower();
                    if (qestRequires.ContainsKey(material))
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
                            qestRequires[material] -= 250;
                            leave = false;
                            break;
                        }
                    }
                    else
                    {
                        if (junk.ContainsKey(material))
                        {
                            junk[material] += quantity;
                        }
                        else
                        {
                            junk.Add(material, quantity);
                        }
                    }
                }


            }

            qestRequires = qestRequires.OrderByDescending(x => x.Value)
                .ThenBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value); 

            foreach (var kvp in qestRequires)
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
