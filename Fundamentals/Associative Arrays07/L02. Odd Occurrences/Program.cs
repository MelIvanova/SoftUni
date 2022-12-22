using System;
using System.Collections.Generic;
using System.Linq;

namespace L02._Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            string[] words = input.Split();
            Dictionary<string, int> oddWords = new Dictionary<string, int>();

            for (int i = 0; i < words.Length; i++)
            {
                if (!oddWords.ContainsKey(words[i]))
                {
                    oddWords.Add(words[i], 0);
                }
                oddWords[words[i]]++;
            }

            foreach (var word in oddWords.Where(x=>x.Value%2!=0))
            {
                Console.Write($"{word.Key} ");
            }
        }
    }
}
