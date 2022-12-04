using System;

namespace _06._Building
{
    class Program
    {
        static void Main(string[] args)
        {
            int floors = int.Parse(Console.ReadLine());
            int rooms = int.Parse(Console.ReadLine());
            for (int i = floors; i >=1 ; i--)
            {
                if (i==floors)
                {
                    for (int m = 0; m < rooms; m++)
                    {
                        Console.Write($"L{i}{m} ");
                        
                    }
                    Console.WriteLine();
                }
                if (i%2==0 && i != floors)
                {
                    for (int m = 0; m < rooms; m++)
                    {
                        Console.Write($"O{i}{m} ");
                    }
                    Console.WriteLine();
                }
                if (i%2!=0 && i!=floors)
                {
                    for (int m = 0; m < rooms; m++)
                    {
                        Console.Write($"A{i}{m} ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
