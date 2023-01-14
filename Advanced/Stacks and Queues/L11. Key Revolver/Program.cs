using System;
using System.Collections.Generic;
using System.Linq;

namespace L11._Key_Revolver
{
    class Program
    {
        static void Main(string[] args)
        {
            int bulletPrice = int.Parse(Console.ReadLine());
            int gunBarrelSize = int.Parse(Console.ReadLine());
            int[] bullets = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int [] lockOrder = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int value = int.Parse(Console.ReadLine());
            int barrel = gunBarrelSize;
            Stack<int> shots = new Stack<int>(bullets);
            Queue<int> locks = new Queue<int>(lockOrder);
            int count = 0;

            while (locks.Any() && shots.Any())
            {
                int currBullet = shots.Pop();
                int currLock = locks.Peek();

                if (currBullet <= currLock)
                {
                    Console.WriteLine("Bang!");
                    locks.Dequeue();
                }
                else
                {
                    Console.WriteLine("Ping!");
                }

                count++;
                barrel--;

                if (barrel==0 && shots.Any())
                {
                    Console.WriteLine("Reloading!");
                    barrel = gunBarrelSize;
                }

            }

            if (locks.Count>0 && shots.Count==0)
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
            }
            else
            {
                int earn = value - (count * bulletPrice);
                Console.WriteLine($"{shots.Count} bullets left. Earned ${earn}");
            }
        }
    }
}
