using System;
using System.Collections.Generic;
using System.Linq;

namespace _401.Arc_KeyRevolver
{
    class Program
    {
        static void Main(string[] args)
        {
            int bulletPrice = int.Parse(Console.ReadLine());
            int gunbarrelSize = int.Parse(Console.ReadLine());
            Stack<int> bullets = new Stack<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
            Queue<int> locks = new Queue<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
            int value = int.Parse(Console.ReadLine());
            int currBarrel = gunbarrelSize;
            int bulletCount = 0;

            while (bullets.Any() && locks.Any())
            {
                currBarrel--;
                bulletCount++;
                if (bullets.Peek() <= locks.Peek())
                {
                    locks.Dequeue();
                    Console.WriteLine("Bang!");
                }
                else
                {
                    Console.WriteLine("Ping!");
                }
                bullets.Pop();

                if (currBarrel==0 && bullets.Any())
                {
                    currBarrel = gunbarrelSize;
                    Console.WriteLine("Reloading!");
                }
            }

            int gaine = value - (bulletCount * bulletPrice);

            if (bullets.Count>=0 && locks.Count==0)
            {
                Console.WriteLine($"{bullets.Count} bullets left. Earned ${gaine}");
            }
            else 
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
            }
        }
    }
}
