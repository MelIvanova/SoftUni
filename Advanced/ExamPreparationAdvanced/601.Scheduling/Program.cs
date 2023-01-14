using System;
using System.Collections.Generic;
using System.Linq;

namespace _601.Scheduling
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> tasks = new Stack<int>(Console.ReadLine().Split(", ").Select(int.Parse).ToArray());
            Queue<int> treads = new Queue<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
            int killTask = int.Parse(Console.ReadLine());

            while (treads.Any())
            {
                if (tasks.Peek() == killTask)
                {
                    Console.WriteLine($"Thread with value {treads.Peek()} killed task {killTask}");
                    break;
                }

                if (treads.Peek() >= tasks.Peek())
                {
                    treads.Dequeue();
                    tasks.Pop();
                }
                else
                {
                    treads.Dequeue();
                }
            }

            Console.WriteLine(String.Join(" ", treads.ToArray()));
        }
    }
    
}
