using System;
using System.Linq;

namespace _303._Heart_Delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] neighborhood = Console.ReadLine().Split('@').Select(int.Parse).ToArray();
            string input = Console.ReadLine();
            int index = 0;

            while (input!= "Love!")
            {
                string[] arguments = input.Split();
                int length = int.Parse(arguments[1]);
                index += length;
                if (index> neighborhood.Length-1)
                {
                    index = 0;
                }
                if (neighborhood[index]>0)
                {
                    neighborhood[index] -= 2;
                    if (neighborhood[index]==0)
                    {
                        Console.WriteLine($"Place {index} has Valentine's day.");
                    }
                }
                else if (neighborhood[index]==0)
                {
                    Console.WriteLine($"Place {index} already had Valentine's day.");
                }                
                input = Console.ReadLine();
            }

            int count = 0;
            for (int i = 0; i < neighborhood.Length; i++)
            {
                if (neighborhood[i]!=0)
                {
                    count++;
                }
            }
            Console.WriteLine($"Cupid's last position was {index}.");

            if (count>0)
            {
                Console.WriteLine($"Cupid has failed {count} places.");
            }
            else
            {
                Console.WriteLine("Mission was successful.");
            }
        }
    }
}
