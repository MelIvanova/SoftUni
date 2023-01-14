using System;

namespace L4._Symbol_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];

            for (int row = 0; row < n; row++)
            {
                char[] input = Console.ReadLine().ToCharArray();

                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            char simbol = char.Parse(Console.ReadLine());
            bool contains = false;
            int rowIndex = 0;
            int colIndex = 0;

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (matrix[row,col] == simbol)
                    {
                        contains = true;
                        rowIndex = row;
                        colIndex = col;
                        break;
                    }
                }

                if (contains)
                {
                    break;
                }

            }

            if (contains)
            {
                Console.WriteLine($"({rowIndex}, {colIndex})");
            }
            else
            {
                Console.WriteLine($"{simbol} does not occur in the matrix");
            }
            
        }
    }
}
