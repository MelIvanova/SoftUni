using System;
using System.Linq;

namespace _3._Maximal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).
                Select(int.Parse).ToArray();
            int rows = input[0];
            int columns = input[1];
            int[,] matrix = new int[rows, columns];

            for (int row = 0; row < rows; row++)
            {
                int[] number = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).
                    Select(int.Parse).ToArray();

                for (int col = 0; col < columns; col++)
                {
                    matrix[row, col] = number[col];
                }
            }

            int sum = 0;
            int indexRow = 0;
            int indexCol = 0;

            for (int row = 0; row < rows - 2; row++)
            {
                
                for (int col = 0; col < columns - 2; col++)
                {
                    int tempSum = 0;
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            tempSum += matrix[row+i, col+j];
                        }
                    }

                    if (tempSum > sum)
                    {
                        sum = tempSum;
                        indexRow = row;
                        indexCol = col;
                    }
                }
            }

            Console.WriteLine($"Sum = {sum}");

            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    Console.Write(matrix[indexRow + row, indexCol + col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
