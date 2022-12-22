using System;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;

namespace Count_Chars_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<char, int> coutingChars = new Dictionary<char, int>();
            int count = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i]==' ')
                {
                    continue;
                }
                else
                {
                    char current = input[i];
                    int index = input.IndexOf(current);
                    while (index!=-1)
                    {
                        count++;
                        index = input.IndexOf(current, index + 1);
                    }
                }
                if (!coutingChars.ContainsKey(input[i]))
                {
                    coutingChars.Add(input[i], count);
                }
           
                count = 0;
            }
            foreach (var kvp in coutingChars)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
