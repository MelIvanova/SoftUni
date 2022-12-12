using System;

namespace _04._Printing_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            PrintTriangle(count);
        }

        static void PrintTriangle(int num)
        {
            PrintTop(num);
            PrintBottpm(num-1);
        }
       
        static void PrintTop(int n)
        {
            for (int counter = 1; counter <= n; counter++)
            {
                for (int i = 1; i <= counter; i++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
        }
        
        static void PrintBottpm(int m)
        {
            for (int number = m; number >= 1; number--)
            {
                for (int i = 1; i <= number; i++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();

            }
        }

    }
}
