using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._Gauss__Trick
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = ReadList();
            for (int i = 0; i < numbers.Count/2; i++)
            {
                Console.Write(numbers[i] + numbers [numbers.Count -1 - i] + " ");
            }
            if (numbers.Count%2!=0)
            {
                Console.Write(numbers[numbers.Count/2]);
            }
        }

         static List<int> ReadList()
        {
            List<int> list = new List<int>();
            string[] elements = Console.ReadLine().Split();
            for (int i = 0; i < elements.Length; i++)
            {
                list.Add(int.Parse(elements[i]));
            }
            return list;
        }
    }
}
