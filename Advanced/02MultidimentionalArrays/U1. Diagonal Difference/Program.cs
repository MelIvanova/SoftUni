using System;
using System.Linq;

namespace U1._Diagonal_Difference
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

            int primary = 0;
            int secondary = 0;

            for (int i = 0; i < n; i++)
            {
                primary += matrix[i, i];
                secondary += matrix[i, n - 1 - i];
            }

            int diff = primary - secondary;
            Console.WriteLine(Math.Abs(diff));
        }
    }
}
