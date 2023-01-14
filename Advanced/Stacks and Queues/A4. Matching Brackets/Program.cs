using System;
using System.Collections.Generic;

namespace A4._Matching_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<int> index = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    index.Push(i);
                }
                else if (input[i] == ')')
                {
                    int start = index.Pop();
                    Console.WriteLine(input.Substring(start, i-start+1));
                }
            }
        }
    }
}
