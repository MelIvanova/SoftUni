using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Word_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine().Split().ToList();
            List<string> evenWords = words.Where(word => word.Length % 2 == 0).ToList();
            foreach (var item in evenWords)
            {
                Console.WriteLine(item);
            }
        }
    }
}
