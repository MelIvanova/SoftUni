
using System;
using System.Linq;

namespace _09.Extract_Middle_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            if (input.Length == 1)
            {
                Console.Write("{ ");
                Console.Write(input[0]);
                Console.Write(" }");
            }
            else if ((input.Length % 2) == 0)
            {
                int[] resultEven = GivMiddelWenEvenNums(input);
                Console.Write("{ ");
                for (int i = 0; i < resultEven.Length; i++)
                {
                    Console.Write(resultEven[i]);
                    if (i == 0)
                    {
                        Console.Write(", ");
                    }
                }
                Console.Write(" }");
            }
            else if ((input.Length % 2) != 0)
            {
                int[] resultOdd = GivMiddelWenOddNums(input);
                Console.Write("{ ");
                for (int i = 0; i < resultOdd.Length; i++)
                {
                    Console.Write(resultOdd[i]);
                    if (i == 0 || i == 1)
                    {
                        Console.Write(", ");
                    }
                }
                Console.Write(" }");
            }


        }

        static int[] GivMiddelWenOddNums(int[] num)
        {
            int[] result = new int[3];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = num[num.Length / 2 -1 + i];
            }
            return result;
        }

        static int[] GivMiddelWenEvenNums(int[] nums)
        {
            int[] result = new int[2];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = nums[nums.Length / 2 - 1 + i];
            }
            return result;
        }
    }
}
