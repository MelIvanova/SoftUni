using System;
using System.Collections.Generic;
using System.Linq;

namespace _302._Shopping_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> shoppingList = Console.ReadLine().Split('!').ToList();
            string input = Console.ReadLine();

            while (input != "Go Shopping!")
            {
                string[] arguments = input.Split();
                string command = arguments[0];
                string item = arguments[1];
                bool isInTheList = shoppingList.Contains(item);

                switch (command)
                {
                   case "Urgent":
                        if (!isInTheList)
                        {
                            shoppingList.Insert(0, item);
                        }
                        break;
                    case "Unnecessary":
                        if (isInTheList)
                        {
                            shoppingList.Remove(item);
                        }
                        break;
                    case "Correct":
                        if (isInTheList)
                        {
                            int index = shoppingList.IndexOf(item);
                            string newItem = arguments[2];
                            shoppingList[index] = newItem;
                        }
                        break;
                    case "Rearrange":
                        if (isInTheList)
                        {
                            shoppingList.Remove(item);
                            shoppingList.Add(item);
                        }
                        break;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ",shoppingList));
        }
    }
}
