using System;
using System.Linq;

namespace FirstLargestThanNeighbors
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            string[] input = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(input[i]);
            }
            //int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            Console.WriteLine(IndexOfLargestNumber(numbers));
        }

        static int IndexOfLargestNumber(int [] numers)
        {
            int index = -1;

            for (int i = 1; i < numers.Length-1; i++)
            {
                if (numers[i-1]< numers[i] && numers[i+1] < numers[i])
                {
                    index = i;
                    break;
                }
            }

            return index;
        }
    }
}
