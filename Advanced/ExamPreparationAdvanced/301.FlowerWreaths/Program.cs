using System;
using System.Collections.Generic;
using System.Linq;

namespace _301.FlowerWreaths
{
    class Program
    {
        static void Main(string[] args)
        {

            Stack<int> lilies = new Stack<int>(Console.ReadLine().Split(", ").Select(int.Parse).ToArray());
            Queue<int> roses = new Queue<int>(Console.ReadLine().Split(", ").Select(int.Parse).ToArray());

            int wreaths = 0;
            int remainFlowers = 0;

            while (lilies.Any() && roses.Any())
            {
                if ((lilies.Peek() + roses.Peek()) == 15)
                {
                    lilies.Pop();
                    roses.Dequeue();
                    wreaths++;
                }
                else if ((lilies.Peek() + roses.Peek()) > 15)
                {
                    int decreasing = lilies.Pop() - 2;
                    lilies.Push(decreasing);
                }
                else if ((lilies.Peek() + roses.Peek()) < 15)
                {
                    remainFlowers += (lilies.Pop() + roses.Dequeue());
                }
            }

            while (remainFlowers >= 15)
            {
                wreaths++;
                remainFlowers -= 15;
            }

            if (wreaths >= 5)
            {
                Console.WriteLine($"You made it, you are going to the competition with {wreaths} wreaths!");
            }
            else
            {
                Console.WriteLine($"You didn't make it, you need {5-wreaths} wreaths more!");
            }
        }
    }
}
