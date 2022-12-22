using System;
using System.Collections.Generic;
using System.Linq;

namespace _5LongestIncreasingSubsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] lineOfNums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            List<int> subsequence = new List<int>();

            for (int i = 0; i < lineOfNums.Length; i++)
            {
                if (subsequence.Count == 0)
                {
                    subsequence.Add(lineOfNums[i]);
                }
                else 
                {
                    if (subsequence[i-1] < lineOfNums[i])
                    {
                        subsequence.Add(lineOfNums[i]);
                    }
                    else if (subsequence[i - 1] > lineOfNums[i])
                    {
                        List<int> list = subsequence;
                        for (int j = list.Count - 1; j >= 0; j--)
                        {
                            if (list[j] > lineOfNums[i])
                            {
                                list.RemoveAt(j);
                                j++;
                            }
                            else if (list[j] == lineOfNums[i])
                            {
                                Console.WriteLine(String.Join((" "), subsequence));
                                return;
                            }
                        }
                        list.Add(lineOfNums[i]);
                        subsequence = list;
                    }
                }
            }
            Console.WriteLine(String.Join((" "), subsequence));
        }
    }
}
