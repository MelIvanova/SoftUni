using System;
using System.Collections.Generic;
using System.Linq;

namespace E06._Reverse_And_Exclude
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).Reverse().ToList();
            int divideBy = int.Parse(Console.ReadLine());
            Func<int, bool> canDivide = n => n % divideBy != 0;
            numbers = numbers.Where(canDivide).ToList();
            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
