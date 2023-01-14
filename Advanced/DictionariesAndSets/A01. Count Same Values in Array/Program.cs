using System;
using System.Collections.Generic;
using System.Linq;

namespace A01._Count_Same_Values_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] input = Console.ReadLine().Split().Select(double.Parse).ToArray();
            Dictionary<double, int> occurrences = new Dictionary<double, int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (!occurrences.ContainsKey(input[i]))
                {
                    occurrences[input[i]] = 0;
                }

                occurrences[input[i]]++;
            }

            foreach (var number in occurrences)
            {
                Console.WriteLine($"{number.Key} - {number.Value} times");
            }
        }
    }
}
