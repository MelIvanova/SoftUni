using System;
using System.Collections.Generic;
using System.Linq;

namespace _201.Bombs
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] bombData = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int[] bombInput = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            Queue<int> bombEffects = new Queue<int>();
            Stack<int> bombCasing = new Stack<int>();

            for (int i = 0; i < bombData.Length; i++)
            {
                bombEffects.Enqueue(bombData[i]);
            }

            for (int i = 0; i < bombInput.Length; i++)
            {
                bombCasing.Push(bombInput[i]);
            }

            SortedDictionary<string, int> pouch = new SortedDictionary<string, int>
            {
                { "Cherry Bombs", 0 },
                { "Datura Bombs",0 },
                { "Smoke Decoy Bombs", 0}
            };

            bool isFull = false;

            while (bombEffects.Any() && bombCasing.Any())
            {
                if ((bombCasing.Peek() + bombEffects.Peek()) == 40 || 
                    (bombCasing.Peek() + bombEffects.Peek()) == 60 ||
                    (bombCasing.Peek() + bombEffects.Peek()) == 120)
                {
                    int result = bombEffects.Dequeue() + bombCasing.Pop();
                    if (result == 40)
                    {
                        pouch["Datura Bombs"]++;
                    }
                    else if (result == 60)
                    {
                        pouch["Cherry Bombs"]++;
                    }
                    else
                    {
                        pouch["Smoke Decoy Bombs"]++;
                    }
                }
                else
                {
                    int decrease = bombCasing.Pop();
                    decrease -= 5;
                    bombCasing.Push(decrease);
                }

                if (PouchFull(pouch))
                {
                    isFull = true;
                    break;
                }

            }

            if (isFull)
            {
                Console.WriteLine("Bene! You have successfully filled the bomb pouch!");
            }
            else
            {
                Console.WriteLine("You don't have enough materials to fill the bomb pouch.");
            }

            if (bombEffects.Any())
            {
                Console.Write("Bomb Effects: ");
                Console.Write(String.Join(", ", bombEffects.ToArray()));
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Bomb Effects: empty");
            }

            if (bombCasing.Any())
            {
                Console.Write("Bomb Casings: ");
                Console.Write(String.Join(", ", bombCasing.ToArray()));
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Bomb Casings: empty");
            }

            foreach (var bomb in pouch)
            {
                Console.WriteLine($"{bomb.Key}: {bomb.Value}");
            }
        }


        private static bool PouchFull(SortedDictionary<string, int> pouch)
        {
            bool full = false;
            int n = 0;

            foreach (var bomb in pouch)
            {
                if (bomb.Value >= 3)
                {
                    n++;
                }
            }

            if (n==3)
            {
                full = true;
            }

            return full;
        }
    }
}
