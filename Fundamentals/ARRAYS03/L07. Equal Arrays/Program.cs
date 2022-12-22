using System;
using System.Linq;

namespace L07._Equal_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] first = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] second = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int index = 0;
            int sum = 0;
            bool areEqual = true;

            for (int i = 0; i < first.Length; i++)
            {
                if (first[i]==second[i])
                {
                    sum += first[i];
                }
                else
                {
                    index = i;
                    areEqual = false;
                    break;
                }
            }
            if (areEqual)
            {
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
            }
            else
            {
                Console.WriteLine($"Arrays are not identical. Found difference at {index} index");
            }

        }
    }
}
