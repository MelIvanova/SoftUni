using System;
using System.Collections.Generic;

namespace NotDivisibleNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            List<int> notDivisible = new List<int>();

            for (int i = 1; i <= number; i++)
            {
                if (i % 3 != 0 && i % 7 != 0)
                {
                    notDivisible.Add(i);
                }
            }

            Console.WriteLine(String.Join(" ", notDivisible));
        }
    }
}
