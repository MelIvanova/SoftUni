using System;
using System.Collections.Generic;

namespace Associative_Arrays___Exersice
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] chInput = input.ToCharArray();
            Dictionary<char, int> orderd = new Dictionary<char, int>();
            for (int i = 0; i < chInput.Length; i++)
            {
                if (chInput[i] == ' ')
                {
                    continue;
                }
                if (!orderd.ContainsKey(chInput[i]))
                {
                    orderd.Add(chInput[i], 1);
                }
                else
                {
                    orderd[chInput[i]]++;
                }
            }
            foreach (var kvp in orderd)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
            
        }
    }
}
