using System;
using System.Linq;

namespace _501TheImitationGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string encriptedMessage = Console.ReadLine();
            string instructions = Console.ReadLine();

            while (instructions != "Decode")
            {
                string[] arguments = instructions.Split('|');
                string command = arguments[0];
                switch (command)
                {
                    case "Move":
                        int number = int.Parse(arguments[1]);
                        string cut = encriptedMessage.Substring(0, number);
                        encriptedMessage = encriptedMessage.Remove(0, number);
                        encriptedMessage = encriptedMessage + cut;
                        break;
                    case "Insert":
                        int index = int.Parse(arguments[1]);
                        string value = arguments[2];
                        encriptedMessage = encriptedMessage.Insert(index, value);
                        break;
                    case "ChangeAll":
                        string old = arguments[1];
                        string newest = arguments[2];
                        encriptedMessage = encriptedMessage.Replace(old, newest);
                        break;
                }
                instructions = Console.ReadLine();
            }

            Console.WriteLine($"The decrypted message is: {encriptedMessage}");
        }
    }
}
