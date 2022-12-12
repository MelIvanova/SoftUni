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
            string command = "";

            while ((command=Console.ReadLine()) != "end")
            {
                string[] input = command.Split();

                if (input.Length == 2)
                {
                    int num = int.Parse(input[1]);
                    numbers.RemoveAll(x => x == num);
                }
                else if (input.Length == 3)
                {
                    int index = int.Parse(input[2]);
                    int element = int.Parse(input[1]);
                    numbers.Insert(index , element);
                }
            }
            Console.WriteLine(string.Join (" ",numbers));
        }
    }
}
