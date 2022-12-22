using System;

namespace _08._Triangle_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                for (int m = 1; m <= i; m++)
                {
                    if (m == i)
                    {
                        Console.Write(i);
                    }
                    else
                    {
                        Console.Write($"{i} ");
                    }
                    
                }
                Console.WriteLine();
            }
        }
    }
}
