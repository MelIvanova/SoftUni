using System;
using System.Linq;

namespace _06._Equal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            bool noFound = true;

            if (numbers.Length==1)
            {
                noFound = false;
                Console.WriteLine(0);
                return;
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                int leftResult = 0;
                int rightResult = 0;

                for (int j = 0; j < i; j++)
                {
                    leftResult += numbers[j];
                }
                for (int m = numbers.Length - 1; m > i; m--)
                {
                    rightResult += numbers[m];
                }

                if (leftResult==rightResult)
                {
                    Console.WriteLine(i);
                    noFound = false;
                    break;
                }

            }

            if (noFound)
            {
                Console.WriteLine("no");
            }
        }
    }
}
