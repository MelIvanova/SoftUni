using System;
using System.Collections.Generic;
using System.Linq;

namespace L01._Count_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();
            Dictionary<double, int> output = new Dictionary<double, int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (!output.ContainsKey(numbers[i]))
                {
                    output.Add(numbers[i], 0);
                }
                output[numbers[i]]++;
            }

            foreach (var num in output.OrderBy(x=>x.Key))
            {
                Console.WriteLine($"{num.Key} -> {num.Value}");
            }
        }
    }
}
