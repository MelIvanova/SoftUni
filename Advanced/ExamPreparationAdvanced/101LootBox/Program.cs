using System;
using System.Collections.Generic;
using System.Linq;

namespace _101LootBox
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> firstBox = new Queue<int>();
            int[] lootBoxOne = Console.ReadLine().
                Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            for (int i = 0; i < lootBoxOne.Length; i++)
            {
                firstBox.Enqueue(lootBoxOne[i]);
            }

            Stack<int> secondBox = new Stack<int>();
            int[] lootBoxTwo = Console.ReadLine().
                Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            for (int i = 0; i < lootBoxTwo.Length; i++)
            {
                secondBox.Push(lootBoxTwo[i]);
            }

            List<int> powerItem = new List<int>();

            while (firstBox.Any() && secondBox.Any())
            {
                if ((firstBox.Peek() + secondBox.Peek()) % 2 == 0)
                {
                    powerItem.Add(firstBox.Dequeue() + secondBox.Pop());
                }
                else
                {
                    firstBox.Enqueue(secondBox.Pop());
                }
            }

            int value = powerItem.Sum();

            if (firstBox.Any())
            {
                Console.WriteLine("Second lootbox is empty");
            }
            else
            {
                Console.WriteLine("First lootbox is empty");
            }

            if (value>=100)
            {
                Console.WriteLine($"Your loot was epic! Value: {value}");
            }
            else
            {
                Console.WriteLine($"Your loot was poor... Value: {value}");
            }
        }
    }
}
