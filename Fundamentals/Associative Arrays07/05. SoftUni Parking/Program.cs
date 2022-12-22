using System;
using System.Collections.Generic;

namespace _05._SoftUni_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            int commandsNumb = int.Parse(Console.ReadLine());
            Dictionary<string, string> register = new Dictionary<string, string>();
            string input = Console.ReadLine();

            for (int i = 0; i < commandsNumb; i++)
            {
                string[] arg = input.Split();
                string command = arg[0];
                string userName = arg[1];

                if (command == "register")
                {
                    string licensePlateNumber = arg[2];
                    if (register.ContainsKey(userName))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {licensePlateNumber}");
                    }
                    else
                    {
                        register.Add(userName, licensePlateNumber);
                        Console.WriteLine($"{userName} registered {licensePlateNumber} successfully");
                    }
                }
                else 
                {
                    if (register.ContainsKey(userName))
                    {
                        Console.WriteLine($"{userName} unregistered successfully");
                        register.Remove(userName);
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {userName} not found");
                    }
                }
                input = Console.ReadLine();
            }

            foreach (var kvp in register)
            {
                Console.WriteLine($"{kvp.Key} => {kvp.Value}");
            }
        }
    }
}
