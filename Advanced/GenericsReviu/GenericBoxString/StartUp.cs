using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericBoxString
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            List<Box<double>> information = new List<Box<double>>();

            for (int i = 0; i < num; i++)
            {
                double current = double.Parse(Console.ReadLine());
                information.Add(new Box<double>(current));
                information[i].Value = current;
            }

            Box<double> compearTo = new Box<double>(double.Parse(Console.ReadLine()));

            int result = BiggerThen(information, compearTo);

            Console.WriteLine(result);

            /*int[] command = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            CustomSwap(information, command);

            for (int i = 0; i < num; i++)
            {
                Console.WriteLine(information[i].ToString());
            }*/
        }

        static int BiggerThen <T>(List<Box<T>> collection, Box<T> element)
            where T : IConvertible, IComparable
        {
            int countElements = 0;

            foreach (Box<T> item in collection)
            {
                int result = item.Value.CompareTo(element.Value);

                if (result > 0)
                {
                    countElements++;
                }
            }

            return countElements;
        }

        static void CustomSwap<T>(List<T> input, int[] command)
        {
            T current = input[command[0]];
            input[command[0]] = input[command[1]];
            input[command[1]] = current;
        }
    }
}
