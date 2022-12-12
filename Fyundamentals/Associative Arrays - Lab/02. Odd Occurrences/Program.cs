using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string input2 = input.ToLower();
            List<string> items = input2.Split().ToList();
            Dictionary<string, int> dict = new Dictionary<string, int>();
            for (int i = 0; i < items.Count; i++)
            {
                if (dict.ContainsKey(items[i]))
                {
                    dict[items[i]]++;
                }
                else
                {
                    dict.Add(items[i], 1);
                }
            }
            foreach (var item in dict)
            {
                if (item.Value % 2!= 0)
                {
                    Console.Write(item.Key+ " ");
                }
            }
          
        }
    }
}
