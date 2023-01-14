using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericListyIterator
{

    class Program
    {
        static void Main(string[] args)
        {
            List<string> commands = Console.ReadLine().Split(" ").ToList();
            string command = commands[0];
            commands.RemoveAt(0);
            ListyIterator<string> list = new ListyIterator<string>(commands);
            while (command != "END")
            {
                switch (command)
                {
                    case "Move":
                        Console.WriteLine(list.Move());
                        break;
                    case "Print":
                        try
                        {
                            list.Print();
                        }
                        catch (InvalidOperationException exeption)
                        {

                            Console.WriteLine(exeption.Message);
                        }
                        break;
                    case "HasNext":
                        Console.WriteLine(list.HasNext());
                        break;
                    case "PrintAll":
                        list.PrintAll();
                        break;
                }
                command = Console.ReadLine();
            }

        }
    }
}
