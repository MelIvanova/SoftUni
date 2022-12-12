
using System;
using System.Collections.Generic;
using System.Linq;

namespace ListsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine().Split().Select(int.Parse).ToList();
            int capacity = int.Parse(Console.ReadLine());
            string command = "";
            int passengers = 0;
            while ((command = Console.ReadLine()) != "end")
            { 
                string[] added = command.Split();
                
                 if (added.Length == 1)
                {
                    passengers = int.Parse(added[0]);
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (wagons[i] + passengers <= capacity )
                        {
                            wagons[i] += passengers;
                            break;
                        }
                        
                    }
                }
                else
                {
                    passengers = int.Parse(added[1]);
                    wagons.Add(passengers);
                }

            }
            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}
