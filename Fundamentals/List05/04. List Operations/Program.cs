using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._List_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] toDo = command.Split();
                if (toDo[0] == "Add")
                {
                    int num = int.Parse(toDo[1]);
                    numbers.Add(num);
                }
                else if (toDo[0] == "Insert")
                {
                    int num = int.Parse(toDo[1]);
                    int index = int.Parse(toDo[2]);
                    
                    if (index >= numbers.Count || index < 0)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        numbers.Insert(index, num);
                    }    
                }
                else if (toDo[0] == "Remove")
                {
                    int index = int.Parse(toDo[1]);
                    if (index >= numbers.Count || index <0)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        numbers.RemoveAt(index); 
                    }
                }
                else if (toDo[1] == "left")
                {
                    int count = int.Parse(toDo[2]);
                    for (int i = 0; i < count; i++)
                    {
                        int curr = numbers[0];
                        numbers.RemoveAt(0);
                        numbers.Add(curr);
                    }
                }
                else if (toDo[1] == "right")
                {
                    int count = int.Parse(toDo[2]);
                    for (int i = 0; i < count; i++)
                    {
                        int curr = numbers[numbers.Count - 1];
                        numbers.RemoveAt(numbers.Count - 1);
                        numbers.Insert(0, curr);
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(' ', numbers));
        }
    }
}
