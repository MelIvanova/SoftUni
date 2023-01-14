using System;
using System.Collections.Generic;


namespace A7._Hot_Potato
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kids = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Queue<string> children = new Queue<string>(kids);
            int passes = int.Parse(Console.ReadLine());

            while (children.Count > 1)
            {
                for (int i = 1; i < passes; i++)
                {
                    string kid = children.Dequeue();
                    children.Enqueue(kid);
                }

                Console.WriteLine($"Removed {children.Dequeue()}");
            }

            Console.WriteLine($"Last is {children.Dequeue()}");
        }
    }
}
