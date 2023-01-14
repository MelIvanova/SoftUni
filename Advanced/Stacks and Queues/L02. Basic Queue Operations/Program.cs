using System;
using System.Collections.Generic;
using System.Linq;

namespace L02._Basic_Queue_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] NSX = Console.ReadLine()
                 .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToArray();
            int adding = NSX[0];
            int popping = NSX[1];
            int lookFor = NSX[2];
            Queue<int> numbers = new Queue<int>();
            int[] elements = Console.ReadLine()
                 .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToArray();

            for (int i = 0; i < adding; i++)
            {
                numbers.Enqueue(elements[i]);
            }

            for (int i = 0; i < popping; i++)
            {
                numbers.Dequeue();
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
                    Console.WriteLine(numbers.Min());
                }
            }
        }
    }
}
