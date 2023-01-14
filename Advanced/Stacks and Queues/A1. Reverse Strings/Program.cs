using System;
using System.Collections.Generic;

namespace A1._Reverse_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> message = new Stack<char>();

            for (int i = 0; i < input.Length; i++)
            {
                message.Push(input[i]);
            }
            while (message.Count>0)
            {
                Console.Write(message.Pop());
            }
            
        }
    }
}
