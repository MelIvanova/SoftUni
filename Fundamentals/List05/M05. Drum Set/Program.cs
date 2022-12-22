using System;
using System.Collections.Generic;
using System.Linq;

namespace M05._Drum_Set
{
    class Program
    {
        static void Main(string[] args)
        {
            List <int> train = Console.ReadLine().Split().Select(int.Parse).ToList();
            int maxCapacity = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] command = input.Split();
                if (command[0] == "Add")
                {
                    int adding = int.Parse(command[1]);
                    train.Add(adding);
                }
                else
                {
                    int adding = int.Parse(command[0]);

                    for (int i = 0; i < train.Count; i++)
                    {
                        if (maxCapacity < (train[i]+adding))
                        {
                            continue;
                        }
                        else
                        {
                            train[i] += adding;
                            break;
                        }
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(' ', train));
        }
    }
}
