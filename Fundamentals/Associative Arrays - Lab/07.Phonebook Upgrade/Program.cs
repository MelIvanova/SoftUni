using System;
using System.Collections.Generic;

namespace _07.Phonebook_Upgrade
{
    class Program
    {
        static void Main(string[] args)
        {
            //75/100
            Dictionary<string, long> goods = new Dictionary<string, long>();
            string resurs = Console.ReadLine();
            long quantity = long.Parse(Console.ReadLine());
            while (resurs != "stop")
            {
                if (!goods.ContainsKey(resurs))
                {
                    goods.Add(resurs, quantity);
                }
                else
                {
                    goods[resurs] += quantity;
                }
                resurs = Console.ReadLine();
                if (resurs != "stop")
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
