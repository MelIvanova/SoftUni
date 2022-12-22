using System;
using System.Linq;

namespace _301SecretChat
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            string instructions = Console.ReadLine();

            while (instructions != "Reveal")
            {
                string[] arguments = instructions.Split(":|:");
                string command = arguments[0];

                switch (command)
                {
                    case "InsertSpace":
                        int indexToInsert = int.Parse(arguments[1]);
                        message = message.Insert(indexToInsert, " ");
                        Console.WriteLine(message);
                        break;
                    case "Reverse":
                        string substring = arguments[1];
                        if (message.Contains(substring))
                        {
                            int index = message.IndexOf(substring);
                            message = message.Substring(0, index) + message.Substring(substring.Length + index);
                            char[] reverce = substring.ToCharArray().Reverse().ToArray();
                            substring = string.Join("", reverce);
                            message = message+substring;
                            Console.WriteLine(message);
                        }
                        else
                        {
                            Console.WriteLine("error");
                        }
                        break;
                    case "ChangeAll":
                        string substr = arguments[1];
                        string replace = arguments[2];
                        message = message.Replace(substr, replace);
                        Console.WriteLine(message);
                        break;
                }

                instructions = Console.ReadLine();
            }

            Console.WriteLine($"You have a new text message: {message}");
        }
    }
}
