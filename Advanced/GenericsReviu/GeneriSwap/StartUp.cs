using System;
using System.Collections.Generic;
using System.Linq;

namespace GeneriSwap
{
   public class StartUp
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            List<string> information = new List<string>();

            for (int i = 0; i < num; i++)
            {
                string current = Console.ReadLine();
                information.Add(current);
            }

            int[] command = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            CustomSwap(information, command);

            int copareTo = int.Parse(Console.ReadLine());

            int result = BiggerThen(information, copareTo);
            
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine(information[i].ToString());
            }
        }

        static int BiggerThen<T>(List<T> collection, T element)
           where T : IComparable
        {
            int countElements = 0;

            foreach (T item in collection)
            {
                int result = item.CompareTo(element);

                if (result > 0)
                {
                    countElements++;
                }
            }

            return countElements;
        }

        static void CustomSwap <T> (List<T> input, int [] command)
        {
            T current = input[command[0]];
            input[command[0]] = input[command[1]];
            input[command[1]] = current;
        }
    }
}
