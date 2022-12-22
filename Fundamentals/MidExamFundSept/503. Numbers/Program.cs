using System;
using System.Collections.Generic;
using System.Linq;

namespace _503._Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            double average = numbers.Average();
            List<int> biggestFive = new List<int>();
            numbers = numbers.Where(x => x > average).ToList();
            if (numbers.Count<1)
            {
                Console.WriteLine("No");
                return;
            }
            numbers = numbers.OrderByDescending(x=>x).ToList();
            if (numbers.Count>5)
            {
                for (int i = 0; i < 5; i++)
                {
                    biggestFive.Add(numbers[i]);
                }
                numbers = biggestFive;
            }
            Console.WriteLine(string.Join(" ",numbers));
            
        }
    }
}
