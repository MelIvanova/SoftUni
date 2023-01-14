using System;
using System.Linq;

namespace U6._Jagged_Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            double[][] jagged = new double[rows][];

            for (int row = 0; row < rows; row++)
            {
                double[] numbers = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).
                    Select(double.Parse).ToArray();
                jagged[row] = numbers;
            }

            for (int row = 0; row < rows; row++)
            {
                if (row + 1 >= rows)
                {
                    break;
                }

                if (jagged[row].Length == jagged[row + 1].Length)
                {
                    jagged[row] = jagged[row].Select(e => e * 2).ToArray();
                    jagged[row + 1] = jagged[row + 1].Select(e => e * 2).ToArray();
                }
                else
                {
                    jagged[row] = jagged[row].Select(e => e / 2).ToArray();
                    jagged[row + 1] = jagged[row + 1].Select(e => e / 2).ToArray();
                }
            }

            string[] arguments = Console.ReadLine().Split();
            string command = arguments[0];

            while (command != "End")
            {
                int row = int.Parse(arguments[1]);
                int col = int.Parse(arguments[2]);
                int value = int.Parse(arguments[3]);

                if (IsValid(row, col, jagged))
                {
                    if (command == "Add")
                    {
                        jagged[row][col] += value;
                    }
                    else if (command == "Subtract")
                    {
                        jagged[row][col] -= value;
                    }
                }
                arguments = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
                command = arguments[0];
            }

            foreach (var column in jagged)
            {
                Console.WriteLine(String.Join(" ", column));
            }
        }

        static bool IsValid(int row, int col, double[][] jagged)
        {
            return row>=0 && row < jagged.Length && col>=0 && col< jagged[row].Length;
        }
    }
}
