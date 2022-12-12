using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Largest_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> number = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> max = new List<int>();
            int count = 0;
            for (int i = 0; i <= number.Count; i++)
            {
                max.Add(number.Max());
                number.Remove(number.Max());
                count++;
                if (count==3)
                {
                    break;
                }
            }
            Console.WriteLine(String.Join(" ", max));
        }
    }
}
