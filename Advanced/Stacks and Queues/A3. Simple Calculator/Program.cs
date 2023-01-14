using System;
using System.Collections.Generic;
using System.Linq;

namespace A3._Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Reverse().ToArray();
            Stack<string> elements = new Stack<string>(input);

            while (elements.Count > 1)
            {
                int first = int.Parse(elements.Pop());
                string operation = elements.Pop();
                int second = int.Parse(elements.Pop());

                if (operation == "+")
                {
                    elements.Push((first + second).ToString());
                }
                else if (operation == "-")
                {
                    elements.Push((first - second).ToString());
                }
            }

            Console.WriteLine(elements.Pop());
        }
    }
}
