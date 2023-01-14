using System;
using System.Linq;

namespace P01RecursiveArraySum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int index = 0;
            Console.WriteLine(SumOfArray(numbers, index));
        }

        private static int SumOfArray(int[] numbers, int index)
        {
           
            if (index == numbers.Length)
            {
                return 0;
            }

            return numbers[index] + SumOfArray(numbers, index+1);
        }
    }
}
