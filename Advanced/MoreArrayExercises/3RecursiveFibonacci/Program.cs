using System;
using System.Collections.Generic;

namespace _3Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int position = int.Parse(Console.ReadLine());
            List<long> fibonacci = new List<long> { 1, 1 };
            long result = GetFibonachiPosition(fibonacci, position);
            Console.WriteLine(result);
        }

        private static long GetFibonachiPosition(List<long> fibonacci, int position)
        {
            long result = 0;
            for (int i = 2; i < position; i++)
            {
                fibonacci.Add(fibonacci[i - 1] + fibonacci[i - 2]);
            }
            result = fibonacci[position - 1];
            return result;
        }
    }
}
