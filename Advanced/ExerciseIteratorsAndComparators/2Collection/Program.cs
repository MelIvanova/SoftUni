using System;
using System.Collections.Generic;
using System.Linq;

namespace _2Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] separators = {',', ' '};
            List<string> collection = Console.ReadLine().Split(separators, 
                StringSplitOptions.RemoveEmptyEntries).ToList();
            collection.RemoveAt(0);
            CustonStack<string> stack = new CustonStack<string>(collection);

            string[] command = Console.ReadLine().Split(' ');

            while (command[0] != "END")
            {
                switch (command[0])
                {
                    case"Push":
                        for (int i = 1; i < command.Length; i++)
                        {
                            stack.Push(command[i]);
                        }
                        break;
                    case "Pop":
                        try
                        {
                            string element = stack.Pop();
                        }
                        catch (InvalidOperationException exception)
                        {
                            Console.WriteLine(exception.Message);
                        } 
                        break;
                }
                command = Console.ReadLine().Split(' ');
            }

            IEnumerable<string> list = stack.ToList();  
            Console.WriteLine(String.Join(System.Environment.NewLine, list));
            Console.WriteLine(String.Join(System.Environment.NewLine, list));

        }
    }
}
