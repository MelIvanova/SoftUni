using System;
using System.Collections.Generic;

namespace _003ThirdProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> chat = new List<string>();
            string input = Console.ReadLine();

            while (input!= "end")
            {
                string[] arguments = input.Split();
                string command = arguments[0];

                switch (command)
                {
                    case "Chat":
                        string message = arguments[1];
                        chat.Add(message);
                        break;
                    case "Delete":
                        string messageToDelete = arguments[1];
                        if (chat.Contains(messageToDelete))
                        {
                            chat.Remove(messageToDelete);
                        }
                        break;
                    case "Edit":
                        string oldMessage = arguments[1];
                        string newMessage = arguments[2];
                        int index = chat.IndexOf(oldMessage);
                        chat[index] = newMessage;
                        break;
                    case "Pin":
                        string movedMessage = arguments[1];
                        int findeIndex = chat.IndexOf(movedMessage);
                        chat.Remove(movedMessage);
                        chat.Add(movedMessage);
                        break;
                    case "Spam":
                        for (int i = 1; i < arguments.Length; i++)
                        {
                            chat.Add(arguments[i]);
                        }
                        break;
                }
                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(Environment.NewLine, chat));
        }
    }
}
