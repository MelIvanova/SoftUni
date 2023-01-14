using System;
using System.Linq;

namespace L5._Square_With_Maximum_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int rows = input[0];
            int columns = input[1];
            int[,] matrix = new int[rows, columns];

            for (int row = 0; row < rows; row++)
            {
                int[] numbers = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int col = 0; col < columns; col++)
                {
                    matrix[row, col] = numbers[col];
                }
            }

            int sumSquare = 0;
            int rowStart = 0;
            int colStart = 0;

            for (int row = 0; row < rows - 1; row++)
            {
                for (int col = 0; col < columns - 1; col++)
                {
                    int currSum = matrix[row, col] + matrix[row, col + 1] +
                        matrix[row + 1, col] + matrix[row + 1, col + 1];

                    if (currSum > sumSquare)
                    {
                        sumSquare = currSum;
                        rowStart = row;
                        colStart = col;
                    }
                }
            }

            Console.WriteLine($"{matrix[rowStart, colStart]} {matrix[rowStart, colStart + 1]}");
            Console.WriteLine($"{matrix[rowStart + 1, colStart]} {matrix[rowStart + 1, colStart + 1]}");
            Console.WriteLine(sumSquare);
        }
    }
}
