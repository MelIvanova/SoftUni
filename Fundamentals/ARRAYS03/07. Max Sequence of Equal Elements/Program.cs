using System;
using System.Linq;

namespace _07._Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int count = 1;
            int curr = 1;
            int equalNum = 0;

            for (int i = 0; i < numbers.Length-1; i++)
            {
                if (numbers[i]==numbers[i+1])
                {
                    curr++;
                }
                else
                {
                    curr = 1;
                }

                if (count<curr)
                {
                    count = curr;
                    equalNum = numbers[i];
                }
            }

            int[] result = new int[count];

            for (int i = 0; i < count; i++)
            {
                result[i] = equalNum;
            }

            Console.WriteLine(string.Join(" ",result));
        }
    }
}
