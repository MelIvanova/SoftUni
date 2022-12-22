using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string comand = Console.ReadLine();

            while (comand != "end")
            {
                string[] doet = comand.Split();

                if (doet[0] == "Delete")
                {
                    int index = int.Parse(doet[1]);
                    numbers.RemoveAll(element => element == index);
                }
                else
                {
                    int index = int.Parse(doet[2]);
                    int element = int.Parse(doet[1]);

                    numbers.Insert(index, element);
                }

                comand = Console.ReadLine();
            }

            Console.WriteLine(string.Join(' ', numbers));
        }
    }
}
