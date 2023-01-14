using System;
using System.Collections.Generic;
using System.Linq;

namespace L12._Cups_and_Bottles
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] cupsCapacity = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int [] bottlesNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> cups = new Queue<int>(cupsCapacity);
            Stack<int> bottles = new Stack<int>(bottlesNumbers);

            int waste = 0;

            while (cups.Any() && bottles.Any())
            {
                int currCup = cups.Dequeue();
                int currBottle = bottles.Pop();

                while (currCup > 0)
                {
                    currCup -= currBottle;

                    if (currCup>0)
                    {
                        currBottle = bottles.Pop();
                    }
                    else
                    {
                        waste += Math.Abs(currCup);
                    }
                }
            }

            if (cups.Any())
            {
                Console.WriteLine($"Cups: {String.Join(" ", cups)}");
            }
            else
            {
                Console.WriteLine($"Bottles: {String.Join(" ", bottles)}");
            }

            Console.WriteLine($"Wasted litters of water: {waste}");
        }
    }
}
