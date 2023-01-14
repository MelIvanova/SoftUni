using System;
using System.Collections.Generic;
using System.Linq;

namespace E03._Custom_Min_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Func<int[], int> smallest = num => num.Min();
            int min = smallest(numbers);
            Console.WriteLine(min);
        }

    }
}
