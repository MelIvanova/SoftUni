using System;
using System.Collections.Generic;
using System.Linq;

namespace L06._Songs_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] playList = Console.ReadLine().Split(", ");
            Queue<string> songsList = new Queue<string>(playList);
            string command = Console.ReadLine();

            while (songsList.Any())
            {
                if (command == "Play")
                {
                    songsList.Dequeue();
                }
                else if (command.Substring(0,3) == "Add")
                {
                    string song = command.Substring(4, command.Length - 4);
                    if (songsList.Contains(song))
                    {
                        Console.WriteLine($"{song} is already contained!");
                    }
                    else
                    {
                        songsList.Enqueue(song);
                    }
                }
                else if (command == "Show")
                {
                    Console.WriteLine(String.Join(", ", songsList));
                }
                command = Console.ReadLine();
            }

            Console.WriteLine("No more songs!");
        }
    }
}
