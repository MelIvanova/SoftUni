using System;
using System.Collections.Generic;
using System.Linq;

namespace E05._Count_Symbols
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<char, int> simbols = new SortedDictionary<char, int>();
            string input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                if (!simbols.ContainsKey(input[i]))
                {
                    simbols[input[i]] = 0;
                }

                simbols[input[i]]++;
            }

            foreach (var letter in simbols)
            {
                Console.WriteLine($"{letter.Key}: {letter.Value} time/s");
            }
        }
    }
}
