using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] bomb = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int explosive = bomb[0];
            int range = bomb[1];


            while (numbers.Contains(explosive))
            {
                if (numbers.Contains(bomb[0]))
                {
                    int index = numbers.IndexOf(explosive);
                    int leftRange = range;
                    int rightRange = range;
                    if (index - leftRange < 0)
                    {
                        leftRange = index;
                    }

                    if (index + rightRange >= numbers.Count)
                    {
                        rightRange = numbers.Count - index - 1;
                    }

                    numbers.RemoveRange(index - leftRange, leftRange + rightRange + 1);

                }
                
            }

            Console.WriteLine(numbers.Sum());
        }
    }
}
