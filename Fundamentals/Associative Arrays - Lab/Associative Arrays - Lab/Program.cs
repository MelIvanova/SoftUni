using System;
using System.Collections.Generic;
using System.Linq;

namespace Associative_Arrays___Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine().Split().Select(double.Parse).ToList();
            SortedDictionary<double, int> counter = new SortedDictionary<double, int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (counter.ContainsKey(numbers[i]))
                {
                    counter[numbers[i]]++;
                }
                else
                {
                    counter.Add(numbers[i], 1);
                }
            }
            foreach (var item in counter)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
