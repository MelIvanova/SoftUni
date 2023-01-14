using System;
using System.Linq;

namespace U2._Squares_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int rows = input[0];
            int columns = input[1];
            string[,] matrix = new string[rows, columns];

            for (int row = 0; row < rows; row++)
            {
                string income = Console.ReadLine();
                string[] letters = income.Split();
                
                for (int col = 0; col < columns; col++)
                {
                    matrix[row, col] = letters[col];
                }
            }

            int count = 0;

            for (int row = 0; row < rows - 1; row++)
            {
                for (int col = 0; col < columns - 1; col++)
                {

                    if (matrix[row,col]==matrix[row,col+1]&&
                        matrix[row, col] == matrix[row+1, col]&&
                        matrix[row, col] == matrix[row+1, col + 1])
                    {
                        count++;
                    }
                   
                }
            }

            Console.WriteLine(count);

        }
    }
}
