using System;

namespace _08._Triangle_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int incom = int.Parse(Console.ReadLine());
            for (int i = 1; i <= incom; i++)
            {
                int num = i;
                for (int m = 1; m <= num; m++)
                {
                    Console.Write($"{num} ");
                }
                Console.WriteLine();
            }
        }
    }
}
