using System;
using System.Collections.Generic;
using System.Linq;

namespace E09._List_Of_Predicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int range = int.Parse(Console.ReadLine());
            int[] dividers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Func<int, int[], List<int>> canDivide = DivideNum;
            List<int> numbers = canDivide(range, dividers);

            Console.WriteLine(String.Join(" ", numbers));
        }

        static List<int> DivideNum (int n, int[] y)
        {
            List<int> numbers = new List<int>();

            for (int i = 1; i <= n; i++)
            {
                bool isDivide = true;
                for (int j = 0; j < y.Length; j++)
                {
                    if (!(i % y[j] == 0))
                    {
                        isDivide = false;
                        break;
                    }
                }
                if (isDivide)
                {
                    numbers.Add(i);
                }
            }

            return numbers;
        }
    }
}
