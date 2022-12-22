using System;
using System.Collections.Generic;

namespace _03._House_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfCommands = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            List<string> guestList = new List<string>();

            for (int i = 0; i < numOfCommands; i++)
            {
                string[] message = command.Split();
                string name = message[0];

                if (message.Length==3)
                {
                    if (guestList.Contains(name))
                    {
                        Console.WriteLine($"{name} is already in the list!");
                    }
                    else
                    {
                        guestList.Add(name);
                    }
                }
                else
                {
                    if (guestList.Contains(name))
                    {
                        guestList.Remove(name);
                    }
                    else
                    {
                        Console.WriteLine($"{name} is not in the list!"); 
                    }
                }

                command = Console.ReadLine();
            }

            foreach (string name in guestList)
            {
                Console.WriteLine(name);
            }
        }
    }
}
