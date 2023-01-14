using System;
using System.Collections.Generic;
using System.Linq;

namespace A2._Stack_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> arrNumb = new Stack<int>(numbers);
            string[] arguments = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            while (arguments[0].ToLower() != "end")
            {
                string command = arguments[0];
                int number = int.Parse(arguments[1]);

                if (command.ToLower() == "add")
                {
                    int secondNumb = int.Parse(arguments[2]);
                    arrNumb.Push(number);
                    arrNumb.Push(secondNumb);
                }
                else if (command.ToLower()== "remove")
                {

                    if (arrNumb.Count < number)
                    {
                        arguments = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                        continue;
                    }
               
                    for (int i = 0; i < number; i++)
                    {
                        arrNumb.Pop();
                    }
                }
                arguments = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            }

            int sum = 0;

            foreach (var num in arrNumb)
            {
                sum += num;
            }

            Console.WriteLine($"Sum: {sum}");
        }
    }
}
