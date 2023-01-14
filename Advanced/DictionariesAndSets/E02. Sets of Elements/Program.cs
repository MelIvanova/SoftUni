using System;
using System.Collections.Generic;
using System.Linq;


namespace E02._Sets_of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] hashLength = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int firstLength = hashLength[0];
            int secondLenght = hashLength[1];
            HashSet<int> first = new HashSet<int>();
            HashSet<int> second = new HashSet<int>();
            int income;

            for (int i = 0; i < firstLength; i++)
            {
                income = int.Parse(Console.ReadLine());
                first.Add(income);
            }

            for (int i = 0; i < secondLenght; i++)
            {
                income = int.Parse(Console.ReadLine());
                second.Add(income);
            }

            first.IntersectWith(second);

            Console.WriteLine(string.Join (" ", first));
        }
    }
}
