using System;
using System.Collections.Generic;

namespace _02._A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> resourcesGain = new Dictionary<string, int>();
            string resource = Console.ReadLine();
            int amount = 0;

            while (resource!="stop")
            {
                amount = int.Parse(Console.ReadLine());
                if (!resourcesGain.ContainsKey(resource))
                {
                    resourcesGain.Add(resource, amount);
                }
                else
                {
                    resourcesGain[resource] += amount;
                }
                resource = Console.ReadLine();
            }
            foreach (var kvp in resourcesGain)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
