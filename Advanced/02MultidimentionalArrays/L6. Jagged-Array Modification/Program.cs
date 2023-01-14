using System;
using System.Linq;

namespace L6._Jagged_Array_Modification
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];

            for (int row = 0; row < n; row++)
            {
                int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = numbers[col];
                }
            }

            string[] arguments = Console.ReadLine().Split();
            string command = arguments[0];

            while (command!= "END")
            {
                int rowIndex = int.Parse(arguments[1]);
                int colIndex = int.Parse(arguments[2]);
                int value = int.Parse(arguments[3]);

                if (IsValide(rowIndex, colIndex, n))
                {
                    if (command == "Add")
                    {
                        matrix[rowIndex, colIndex] += value;
                    }
                    else if (command == "Subtract")
                    {
                        matrix[rowIndex, colIndex] -= value;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid coordinates");
                }

                arguments = Console.ReadLine().Split();
                command = arguments[0];
            }

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write(matrix[row,col] + " ");
                }

                Console.WriteLine();
            }

        }

        private static bool IsValide(int rowIndex, int colIndex, int n)
        {
            return rowIndex >= 0 && rowIndex < n && colIndex >= 0 && colIndex < n;
        }
    }
}
