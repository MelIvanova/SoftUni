using System;
using System.Collections.Generic;

namespace _02._A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, long> goods = new Dictionary<string, long>();
            string resource = Console.ReadLine();
            long quantity = long.Parse(Console.ReadLine());
            while (resource!= "stop")
            {
               
                if (!goods.ContainsKey(resource))
                {
                    goods.Add(resource, quantity);
                }
                else
                {
                    goods[resource] += quantity;
                }
                resource = Console.ReadLine();
                if (resource != "stop")
                {
                    quantity = long.Parse(Console.ReadLine());
                }
                
                
            }
            foreach (var kvp in goods)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
            
        }
    }
}
