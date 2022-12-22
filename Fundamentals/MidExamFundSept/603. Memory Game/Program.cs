using System;
using System.Collections.Generic;
using System.Linq;

namespace _603._Memory_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> elements = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            string input = Console.ReadLine();
            int count = 0;

            while (input != "end")
            {
                string[] indexes = input.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                int firstIndex = int.Parse(indexes[0]);
                int secondIndex = int.Parse(indexes[1]);
                count++;

                bool autOfBoundery = firstIndex == secondIndex ||
                    firstIndex < 0 || secondIndex < 0 ||
                    firstIndex >= elements.Count ||
                    secondIndex >= elements.Count;

                if (autOfBoundery)
                {
                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                    elements.Insert(elements.Count / 2, $"-{count}a");
                    elements.Insert(elements.Count / 2, $"-{count}a");
                    input = Console.ReadLine();
                    continue;
                }
                string firstElement = elements[firstIndex];
                string secondElement = elements[secondIndex];

                if (firstElement == secondElement)
                {
                    Console.WriteLine($"Congrats! You have found matching elements - {firstElement}!");

                    elements.Remove(firstElement);
                    elements.Remove(secondElement);

                }
                else
                {
                    Console.WriteLine("Try again!");
                }

                if (elements.Count == 0)
                {
                    Console.WriteLine($"You have won in {count} turns!");
                    break;
                }

                input = Console.ReadLine();
            }

            if (elements.Count > 0)
            {
                Console.WriteLine("Sorry you lose :(");
                Console.WriteLine(string.Join(" ", elements));
            }
        }
    }
}
