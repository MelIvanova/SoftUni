using System;
using System.Collections.Generic;
using System.Linq;

namespace L05._Fashion_Boutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] box = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Stack<int> clothes = new Stack<int>(box);
            int capacity = int.Parse(Console.ReadLine());
            int count = 0;
            int currentRack = capacity;

            while (clothes.Count > 0)
            {
                if (currentRack >= clothes.Peek())
                {
                    currentRack -= clothes.Pop();
                    if (clothes.Count==0)
                    {
                        count++;
                    }
                }
                else
                {
                    count++;
                    currentRack = capacity;
                }
            }

            Console.WriteLine(count);
        }
    }
}
