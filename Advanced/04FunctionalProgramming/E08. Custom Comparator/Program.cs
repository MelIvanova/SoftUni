using System;
using System.Collections.Generic;
using System.Linq;

namespace E08._Custom_Comparator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            Func<List<int>, List<int>> sorting = EvenOdd;
            Console.WriteLine(String.Join(" ", sorting(numbers)));
        }

        static List<int> EvenOdd(List<int> numbers)
        {
            List<int> even = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    even.Add(numbers[i]);
                }
            }

            even.Sort();

            List<int> odd = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 != 0)
                {
                    odd.Add(numbers[i]);
                }
            }

            odd.Sort();

            foreach (var num in odd)
            {
                even.Add(num);
            }

            return even;

        }
    }
}
