using System;
using System.Linq;
using System.Collections.Generic;

namespace _06._List_Manipulation_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command = "";
            while (command != "end")
            {
                command = Console.ReadLine();
                string[] tokens = command.Split();
                switch (tokens[0])
                {
                    case "Add":
                        int addNumber = int.Parse(tokens[1]);
                        numbers.Add(addNumber); 
                        break;
                    case "Remove":
                        int removeNumber = int.Parse(tokens[1]);
                        numbers.Remove(removeNumber);
                        break;
                    case "RemoveAt":
                        int removeAtIndex = int.Parse(tokens[1]);
                        numbers.RemoveAt(removeAtIndex); 
                        break;
                    case "Insert":
                        int numberToInsert = int.Parse(tokens[1]);
                        int indexToInsert = int.Parse(tokens[2]);
                        numbers.Insert(indexToInsert, numberToInsert);
                        break;
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
