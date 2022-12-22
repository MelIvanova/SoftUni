using System;
using System.Linq;

namespace _4FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] firstRow = new int[input.Length/2];
            int[] secondRow = new int[input.Length/2];
            int[] results = new int[input.Length/2];

            int foldNum = input.Length/4 - 1;
            int index = 0;
            for (int i = foldNum; i >= 0; i--)
            {
                firstRow[index] = input[i];
                index++;
            }
            foldNum = input.Length/4 + input.Length/2;
            for (int i = input.Length-1; i >= foldNum; i--)
            {
                firstRow[index] = input[i];
                index++;
            }

            foldNum = input.Length / 4;
            index= 0;
            for (int i = foldNum; i < secondRow.Length + foldNum; i++)
            {
                secondRow[index] = input[i];
                index++;
            }

            for (int i = 0; i < results.Length; i++)
            {
                results[i] = firstRow[i] + secondRow[i];
            }

            Console.WriteLine(String.Join((" "), results));
        }
    }
}
