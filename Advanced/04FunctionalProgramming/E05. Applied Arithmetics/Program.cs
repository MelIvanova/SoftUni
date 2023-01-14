using System;
using System.Collections.Generic;
using System.Linq;

namespace E05._Applied_Arithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command = Console.ReadLine();
            Func<int, int> addOne = n => n = n+1;
            Func<int, int> multiply = n => n * 2;
            Func<int, int> subtract = n => n = n-1;

            while (command != "end")
            {
                switch (command)
                {
                    case "add":
                       numbers =  numbers.Select(addOne).ToList();
                        break;
                    case "multiply":
                        numbers = numbers.Select(multiply).ToList();
                        break;
                    case "subtract":
                        numbers = numbers.Select(subtract).ToList();
                        break;
                    case "print":
                        Console.WriteLine(String.Join(" ", numbers));
                        break;
                }

                command = Console.ReadLine();
            }
        }
    }
}
