using System;
using System.Collections.Generic;
using System.Linq;

namespace A5._Print_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                           .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                           .Select(int.Parse)
                           .ToArray();
            Queue<int> evenNumb = new Queue<int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] % 2 == 0)
                {
                    evenNumb.Enqueue(input[i]);
                }
            }

            while (evenNumb.Count>1)
            {
                Console.Write($"{evenNumb.Dequeue()}, ");
            }

            Console.Write(evenNumb.Dequeue());
        }
    }
}
