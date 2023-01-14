using System;
using System.Collections.Generic;

namespace NumbersTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            List<int> lines = new List<int>();

            for (int i = 1; i <= number; i++)
            {
                lines.Add(i);
                Console.WriteLine(String.Join(" ", lines));
            }

            lines.RemoveAt(number - 1);

            for (int i = number - 2; i >= 0; i--)
            {
                Console.WriteLine(String.Join(" ", lines));
                lines.RemoveAt(i);
            }
        }
    }
}
