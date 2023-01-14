using System;
using System.Collections.Generic;
using System.Linq;

namespace L03._Maximum_and_Minimum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int income = int.Parse(Console.ReadLine());
            Stack<int> numbers = new Stack<int>();
            

            for (int i = 0; i < income; i++)
            {
                int[] arguments = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                int command = arguments[0];

                switch (command)
                {
                    case 1 :
                        numbers.Push(arguments[1]);
                        break;
                    case 2 :
                        if (numbers.Count > 0)
                        {
                            numbers.Pop();
                        } 
                        break;
                    case 3 :
                        if (numbers.Count>0)
                        {
                            Console.WriteLine(numbers.Max());
                        }
                        break;
                    case 4 :
                        if (numbers.Count > 0)
                        {
                            Console.WriteLine(numbers.Min());
                        }
                        break;
                }
                
            }

            Console.WriteLine(String.Join(", ", numbers));
        }
    }
}
