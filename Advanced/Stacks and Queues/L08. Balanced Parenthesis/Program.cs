using System;
using System.Collections.Generic;
using System.Linq;

namespace L08._Balanced_Parenthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> open = new Stack<char>();
            bool isBalaced = true;

            foreach (char paranthese in input)
            {
                if (paranthese == '(' || paranthese == '[' || paranthese == '{')
                {
                    open.Push(paranthese);
                }
                else
                {
                    if (open.Count==0)
                    {
                        isBalaced = false;
                        break;
                    }
                    if (paranthese == ')' && open.Pop() == '(' || paranthese == ']' && open.Pop() == '['|| 
                        paranthese == '}' && open.Pop() == '{')
                    {
                        isBalaced = true;
                    }
                    else
                    {
                        isBalaced = false;
                        break;
                    }
                }
            }

            if (isBalaced)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
