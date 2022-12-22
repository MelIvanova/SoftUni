using System;
using System.Linq;

namespace _01FirstTack
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string input = Console.ReadLine();

            while (input!="End")
            {
                string[] arguments = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = arguments[0];

                switch (command)
                {
                    case "Translate":
                        string finde = arguments[1];
                        string replace = arguments[2];
                        text = text.Replace(finde, replace);
                        Console.WriteLine(text);
                        break;
                    case "Includes":
                        string other = arguments[1];
                        if (text.Contains(other))
                        {
                            Console.WriteLine("True");
                        }
                        else
                        {
                            Console.WriteLine("False");
                        }
                        break;
                    case "Start":
                        string starts = arguments[1];
                        string subs = text.Substring(0, starts.Length);
                        if (starts==subs)
                        {
                            Console.WriteLine("True");
                        }
                        else
                        {
                            Console.WriteLine("False");
                        }
                        break;
                    case "Lowercase":
                        text = text.ToLower();
                        Console.WriteLine(text);
                        break; 
                    case "FindIndex":
                        char toFind = char.Parse(arguments[1]);
                        int index = text.LastIndexOf(toFind);
                        Console.WriteLine(index);
                        break;
                    case "Remove":
                        int startIndex = int.Parse(arguments[1]);
                        int length = int.Parse(arguments[2]);
                        text = text.Remove(startIndex, length);
                        Console.WriteLine(text);
                        break;

                }
                input = Console.ReadLine();
            }
        }
    }
}
