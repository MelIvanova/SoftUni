using System;
using System.Runtime.CompilerServices;

namespace _02._Repeat_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            string result = "";
            for (int i = 0; i < input.Length; i++)
            {
                string word = input[i];
                for (int m = 0; m < word.Length; m++)
                {
                    result += word;
                }
            }
            Console.WriteLine(result);
        }

    }
}
