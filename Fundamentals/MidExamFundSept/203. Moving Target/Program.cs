using System;
using System.Collections.Generic;
using System.Linq;

namespace _203._Moving_Target
{
    class Program
    {
        static void Main(string[] args)
        {
            List <int> targets = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] arguments = command.Split();
                string manipulation = arguments[0];
                int index = int.Parse(arguments[1]);
                int value = int.Parse(arguments[2]);

                switch (manipulation)
                {
                    case "Shoot":
                        if (index>=0 && index<targets.Count)
                        {
                            targets[index] -= value;
                            if (targets[index]<=0)
                            {
                                targets.RemoveAt(index);
                            }
                        }
                        break;
                    case "Add":
                        if (index >= 0 && index < targets.Count)
                        {
                            targets.Insert(index, value);
                        }
                        else
                        {
                            Console.WriteLine("Invalid placement!");
                        }
                        break;
                    case "Strike":
                        int start = index - value;
                        int end = index + value;
                        if (start<0 || end >= targets.Count)
                        {
                            Console.WriteLine("Strike missed!");
                        }
                        else
                        {
                            for (int i = start; i <= end; i++)
                            {
                                targets.RemoveAt(start);
                            }
                        }
                        break;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join("|",targets));
        }
    }
}
