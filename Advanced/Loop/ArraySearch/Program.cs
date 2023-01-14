using System;
using System.Collections.Generic;
using System.Linq;

namespace ArraySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(",").Select(int.Parse).ToArray();
            List<int> numbersNotFound = new List<int>();

            for (int i = 1; i <= numbers.Length; i++)
            {
                if (!numbers.Contains(i))
                {
                    numbersNotFound.Add(i);
                }
            }

            Console.WriteLine(String.Join(",", numbersNotFound));
        }
    }
}
