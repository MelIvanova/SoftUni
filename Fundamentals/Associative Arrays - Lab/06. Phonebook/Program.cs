using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _06._Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            Dictionary<string, string> phoneBook = new Dictionary<string, string>();
            while (command!= "END")
            {
                string[] input = command.Split();
                if (input[0] == "A")
                {
                    if (!phoneBook.ContainsKey(input[1]))
                    {
                        phoneBook.Add(input[1], input[2]);
                    }
                    else
                    {
                        phoneBook[input[1]] = input[2];
                    }

                }
                else if (input[0] == "S")
                {
                    if (phoneBook.ContainsKey(input[1]))
                    {
                        phoneBook.TryGetValue(input[1], out string result);
                        Console.WriteLine($"{input[1]} -> {result}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {input[1]} does not exist.");
                    }
                    
                }
                if (command== "ListAll")
                {
                  var orferd = phoneBook.OrderBy(x => x.Key);
                    foreach (var kvp in orferd)
                    {
                        Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
                    }

                }
                command = Console.ReadLine();
            }
        }
    }
}
