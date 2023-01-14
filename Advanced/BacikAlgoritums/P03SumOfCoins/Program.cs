using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace P03SumOfCoins
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] separators = { ',', ' ' };
            string[] inputCoins = Console.ReadLine().Split(separators,
                StringSplitOptions.RemoveEmptyEntries).Skip(1).ToArray();

            int[] coin = inputCoins.Select(int.Parse).ToArray();
            coin = coin.OrderByDescending(x => x).ToArray();
            Queue<int> spend = new Queue<int>();
            string[] amount = Console.ReadLine().Split(' ',
                StringSplitOptions.RemoveEmptyEntries);
            int change = int.Parse(amount[1]);
            int index = 0;
            int numberOfCoinsTaken = 0;

            while (change != 0)
            {
                if (change>0 && index == coin.Length)
                {
                    Console.WriteLine("Error");
                    return;
                }
                if (change - coin[index] >= 0)
                {
                    change -= coin[index];
                    spend.Enqueue(coin[index]);
                    numberOfCoinsTaken++;
                }
                else
                {
                    index++;
                }
            }

            Console.WriteLine($"Number of coins to take: {numberOfCoinsTaken}");
            PrintCoins(spend);
        }

        private static void PrintCoins(Queue<int> spend)
        {
            int count = 0;
            while (spend.Count > 0)
            {
                int current = spend.Dequeue();
                if (spend.Count == 0)
                {
                    count++;
                    Console.WriteLine($"{count} coin(s) with value {current}");
                }
                else if (spend.Peek() == current)
                {
                    count++;
                }
                else
                {
                    count++;
                    Console.WriteLine($"{count} coin(s) with value {current}");
                    count = 0;
                }
            }
        }
    }
}
