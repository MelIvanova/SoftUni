using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Randomize_Words
{
    class Program
    {
        

        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine().Split().ToList();
            Random order = new Random();
            int counter = words.Count;
            for (int i = 0; i < counter; i++)
            {
                int index = order.Next(0, words.Count-1);
                if (words.Contains(words[index]))
                {
                    Console.WriteLine(words[index]);
                    words.Remove(words[index]);
                }
                
            }


        }
    }
}
