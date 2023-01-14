using System;
using System.Collections.Generic;
using System.Linq;

namespace L01.BasicStackOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] NSX = Console.ReadLine()
                 .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToArray();
            int pushN = NSX[0];
            int popS = NSX[1];
            int lookFor = NSX[2];
            Stack<int> numbers = new Stack<int>();
            int[] elements = Console.ReadLine()
                 .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToArray();

            for (int i = 0; i < pushN; i++)
            {
                numbers.Push(elements[i]);
            }

            for (int i = 0; i < popS; i++)
            {
                numbers.Pop();
            }

            if (numbers.Count == 0)
            {
                Console.WriteLine('0');
            }
            else
            {
                if (numbers.Contains(lookFor))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    int smallest = numbers.Pop();
                    for (int i = 0; i < numbers.Count-1; i++)
                    {
                        if (numbers.Peek() < smallest)
                        {
                            smallest = numbers.Pop();
                        }
                    }
                    Console.WriteLine(smallest);
                }
            }
        }
    }
}
