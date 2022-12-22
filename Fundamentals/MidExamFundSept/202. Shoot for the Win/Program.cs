using System;
using System.Linq;
using System.Runtime.CompilerServices;

namespace _202._Shoot_for_the_Win
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] targerts = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int count = 0;
            string income = Console.ReadLine();

            while (income !="End")
            {
                int index = int.Parse(income);
               
                if (index>=0 && index < targerts.Length)
                {
                    int points = targerts[index];
                    if (points != -1)
                    {
                        count++;
                        for (int i = 0; i < targerts.Length; i++)
                        {
                            if (targerts[i] != -1)
                            {
                                if (points >= targerts[i])
                                {
                                    targerts[i] += points;
                                }
                                else
                                {
                                    targerts[i] -= points;
                                }
                            }
                        }
                    }
                    targerts[index] = -1;
                }
                income = Console.ReadLine();
            }
            Console.Write($"Shot targets: { count} -> ");
            foreach (int item in targerts)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
