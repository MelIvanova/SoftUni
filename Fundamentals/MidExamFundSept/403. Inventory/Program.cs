using System;
using System.Collections.Generic;
using System.Linq;

namespace _403._Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> items = Console.ReadLine().Split(", ").ToList();
            string input = Console.ReadLine();

            while (input != "Craft!")
            {
                string[] arguments = input.Split(" - ");
                string command = arguments[0];
                string item = arguments[1];

                switch (command)
                {
                    case "Collect":
                        if (!items.Contains(item))
                        {
                            items.Add(item);
                        }
                        break;
                    case "Drop":
                        if (items.Contains(item))
                        {
                            items.Remove(item);
                        }
                        break;
                            case "Combine Items":
                        string[] oldAndNew = item.Split(":");
                        string oldItem = oldAndNew[0];
                        string newItem = oldAndNew[1];
                        if (items.Contains(oldItem))
                        {
                            int oldIndex = items.IndexOf(oldItem);
                            items.Insert(oldIndex + 1, newItem);
                        }
                        break;
                    case "Renew":
                        if (items.Contains(item))
                        {
                            items.Remove(item);
                            items.Add(item);
                        }
                        break;
                }
                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", items));
        }
    }
}
