using System;
using System.Collections.Generic;
using System.Linq;

namespace OddOrEvenProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            long [] numbers = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            long evenResult = 1;
            long oddResult = 1;

            for (long i = 0; i < number; i++)
            {
                long current = numbers[i];
                //int current = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    evenResult *= current;
                }
                else
                {
                    oddResult *= current;
                }
            }

            if (evenResult==oddResult)
            {
                Console.WriteLine($"yes {evenResult}");
            }
            else
            {
                Console.WriteLine($"no {evenResult} {oddResult}");
            }
        }
    }
}
