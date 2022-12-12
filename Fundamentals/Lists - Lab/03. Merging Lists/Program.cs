using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace _03._Merging_Lists
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> joinLists = JoiningLosts();
            List<int> jonListVariantTow = JoiningLosts2();
            Console.Write(string.Join(" ", joinLists));
            Console.WriteLine();
            Console.Write(string.Join(" ", jonListVariantTow));
        }

        static List<int> JoiningLosts()
        {
            List<int> lineOne = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> lineTow = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> result = new List<int>();
            int length = 0;
            if (lineOne.Count >= lineTow.Count)
            {
                length = lineTow.Count;
            }
            else
            {
                length = lineOne.Count;
            }

            for (int i = 0; i < length; i++)
            {
                result.Add(lineOne[i]);
                result.Add(lineTow[i]);
            }
            if (lineOne.Count > lineTow.Count)
            {
                for (int i = 0; i < lineOne.Count - length; i++)
                {
                    result.Add(lineOne[length + i]);
                }
            }
            else if (lineOne.Count < lineTow.Count)
            {
                for (int i = 0; i < lineTow.Count - length; i++)
                {
                    result.Add(lineTow[length + i]);
                }
            }
            return result;
        }
        static List<int> JoiningLosts2()
        {
            List<int> lineOne = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> lineTow = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> result = new List<int>();
            int length = Math.Max(lineOne.Count, lineTow.Count);
            for (int i = 0; i < length; i++)
            {
                if (i<lineOne.Count)
                {
                    result.Add(lineOne[i]);
                }
                if (i < lineTow.Count)
                {
                    result.Add(lineTow[i]);
                }
            }
            return result;
        }
    }
}
