using System;
using System.Linq;

namespace U5._Snake_Moves
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = input[0];
            int columns = input[1];
            string snake = Console.ReadLine();
            int path = 0;
            char[,] snakeMoves = new char[rows, columns];

            for (int row = 0; row < rows; row++)
            {
                if (row % 2 == 0)
                {
                    for (int col = 0; col < columns; col++)
                    {
                        if (path >= snake.Length)
                        {
                            path = 0;
                        }

                        snakeMoves[row, col] = snake[path];
                        path++;
                    }
                }
                else
                {
                    for (int col = columns-1; col >= 0; col--)
                    {
                        if (path >= snake.Length)
                        {
                            path = 0;
                        }

                        snakeMoves[row, col] = snake[path];
                        path++;
                    }
                }
            }

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < columns; col++)
                {
                    Console.Write(snakeMoves[row,col]);
                }
                Console.WriteLine();
            }
        }
    }
}
