using System;

namespace _05.PrintTriangle
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            PrintTriangle(number);
        }

        static void PrintTriangle(int num)
        {
            PrintTop(num);
            PrintBottom(num);
        }

        static void PrintTop(int num)
        {
            for (int row = 1; row <= num; row++)
            {
                for (int collum = 1; collum <= row; collum++)
                {
                    Console.Write(collum + " ");
                    
                }
                Console.WriteLine();
            }
        }

        static void PrintBottom(int num)
        {
            for (int row = num - 1; row >= 1; row--)
            {
                for (int collum = 1; collum <= row; collum++)
                {
                    Console.Write(collum + " ");
                    
                }
                Console.WriteLine();
            }
        }
    }
}
