using System;
using System.Collections.Generic;
using System.Linq;

namespace _602.Garden
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = size[0];
            int m = size[1];
            int[,] garden = new int[n, m];

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < m; col++)
                {
                    garden[row, col] = 0;
                }
            }

            string comand = Console.ReadLine();
            List<int> valideCoordinates = new List<int>();

            while (comand != "Bloom Bloom Plow")
            {
                int[] coordinates = comand.Split().Select(int.Parse).ToArray();
                int row = coordinates[0];
                int col = coordinates[1];

                if (IsValide(row, col, n, m))
                {
                    valideCoordinates.Add(row);
                    valideCoordinates.Add(col);
                }
                else
                {
                    Console.WriteLine("Invalid coordinates.");
                }

                comand = Console.ReadLine();
            }

            for (int i = 0; i < valideCoordinates.Count; i++)
            {
                int row = valideCoordinates[i];
                i++;
                int col = valideCoordinates[i];
                garden = Blooming(garden, row, col);
            }

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < m; col++)
                {
                    if (col != m - 1)
                    {
                        Console.Write(garden[row, col] + " ");
                    }
                    else
                    {
                        Console.Write(garden[row, col]);
                    }

                }
                Console.WriteLine();
            }

        }

        private static int[,] Blooming(int[,] garden, int row, int col)
        {
            for (int c = 0; c < garden.GetLength(1); c++)
            {
                if (c == col)
                {
                    continue;
                }
                garden[row, c] += 1;
            }
            for (int r = 0; r < garden.GetLength(0); r++)
            {
                garden[r, col] += 1;
            }

            return garden;
        }

        private static bool IsValide(int row, int col, int n, int m)
        {
            return row < n && row >= 0 && col < m && col >= 0;
        }
    }
}
