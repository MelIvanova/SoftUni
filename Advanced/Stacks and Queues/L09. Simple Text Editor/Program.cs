using System;
using System.Collections.Generic;
using System.Text;

namespace L09._Simple_Text_Editor
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());

            StringBuilder text = new StringBuilder();
            Stack<string> stack = new Stack<string>();
            stack.Push(text.ToString());

            for (int i = 0; i < lines; i++)
            {
                string[] input = Console.ReadLine().Split();
                int command = int.Parse(input[0]);

                switch (command)
                {
                    case 1:
                        text.Append(input[1]);
                        stack.Push(text.ToString());
                        break;
                    case 2:
                        int number = int.Parse(input[1]);
                        text.Remove(text.Length - number, number);
                        stack.Push(text.ToString());
                        break;
                    case 3:
                        int index = int.Parse(input[1]);
                        Console.WriteLine(text[index - 1]);
                        break;
                    case 4:
                        stack.Pop();
                        text = new StringBuilder();
                        text.Append(stack.Peek());
                        break;
                }
            }
        }
    }
}
