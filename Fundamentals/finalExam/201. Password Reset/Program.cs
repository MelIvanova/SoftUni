using System;
using System.Collections.Generic;

namespace _201._Password_Reset
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            string input = Console.ReadLine();

            while (input != "Done")
            {
                string[] commandArgs = input.Split(' ');
                string command = commandArgs[0];

                if (command == "TakeOdd")
                {
                    List<char> rawPassword = new List<char>();

                    for (int i = 0; i < password.Length; i++)
                    {
                        if (i % 2 != 0)
                        {
                            rawPassword.Add(password[i]);
                        }
                    }
                    password = string.Join("", rawPassword);

                    Console.WriteLine(password);
                }
                else if (command == "Cut")
                {
                    int index = int.Parse(commandArgs[1]);
                    int length = int.Parse(commandArgs[2]);
                    password = password.Remove(index, length);
                    Console.WriteLine(password);
                }
                else if (command == "Substitute")
                {
                    string substring = commandArgs[1];
                    string replace = commandArgs[2];
                    if (password.Contains(substring))
                    {
                        password = password.Replace(substring, replace);
                        Console.WriteLine(password);
                    }
                    else
                    {
                        Console.WriteLine("Nothing to replace!");
                    }

                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Your password is: {password}");
        }
    }
}
