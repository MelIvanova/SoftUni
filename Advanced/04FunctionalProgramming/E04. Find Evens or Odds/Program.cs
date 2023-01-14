using System;
using System.Collections.Generic;
using System.Linq;

namespace E04._Find_Evens_or_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] rage = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string command = Console.ReadLine();
            Predicate<int> odd = n => n % 2 != 0;
            Predicate<int> even = n => n % 2 == 0;
            List<int> result = new List<int>();

            if (command == "odd")
            {
                for (int i = rage[0]; i <= rage[1]; i++)
                {
                    if (odd(i))
                    {
                        result.Add(i);
                    }
                }
            }
            else if (command == "even")
            {
                for (int i = rage[0]; i <= rage[1]; i++)
                {
                    if (even(i))
                    {
                        result.Add(i);
                    }
                }
            }

            Console.WriteLine(String.Join(" ", result));
        }
    }
}
