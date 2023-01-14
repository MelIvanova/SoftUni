using System;
using System.Linq;

namespace U4._Matrix_Shuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] range = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                         .Select(int.Parse).ToArray();
            int rows = range[0];
            int columns = range[1];

            string[,] matrix = new string[rows, columns];

            for (int row = 0; row < rows; row++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                for (int col = 0; col < columns; col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            string[] arguments = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string command = arguments[0];

            while (command != "END")
            {
                if (arguments.Length==5 && command == "swap")
                {
                    int firstRow = int.Parse(arguments[1]);
                    int firstCol = int.Parse(arguments[2]);
                    int secondRow = int.Parse(arguments[3]);
                    int secondCol = int.Parse(arguments[4]);
                    if (IsValide(firstRow,firstCol,secondRow,secondCol,matrix))
                    {
                        string temp = matrix[firstRow, firstCol];
                        matrix[firstRow, firstCol] = matrix[secondRow, secondCol];
                        matrix[secondRow, secondCol] = temp;

                        for (int row = 0; row < rows; row++)
                        {
                            for (int col = 0; col < columns; col++)
                            {
                                Console.Write(matrix[row,col]+ " ");
                            }
                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
                
                arguments = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                command = arguments[0];
            }
        }

        static bool IsValide(int firstRow, int firstCol, int secondRow, int secondCol, string[,] matrix)
        {
            return firstRow >= 0 && firstRow < matrix.GetLength(0) && firstCol >= 0 && firstCol < matrix.GetLength(1) &&
                 secondRow >= 0 && secondRow < matrix.GetLength(0) && secondCol >= 0 && secondCol < matrix.GetLength(1);
        }
    }
}
