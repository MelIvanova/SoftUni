using System;
using System.Collections.Generic;
using System.Linq;

namespace U8._Bombs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] mineFeeld = new int[n, n];

            for (int row = 0; row < n; row++)
            {
                int[] input = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).
                    Select(int.Parse).ToArray();
                for (int col = 0; col < n; col++)
                {
                    mineFeeld[row, col] = input[col];
                }
            }

            int[] income = Console.ReadLine().Split(' ', ',').Select(int.Parse).ToArray();
            Queue<int> bombIndexes = new Queue<int>(income);

            while (bombIndexes.Any())
            {
                int rowBomb = bombIndexes.Dequeue();
                int colBomb = bombIndexes.Dequeue();
                int value = mineFeeld[rowBomb, colBomb];

                for (int row = rowBomb-1; row <= rowBomb+1; row++)
                {
                    for (int col = colBomb-1; col <= colBomb+1; col++)
                    {
                        if (row >= 0 && row < n && col >= 0 && col < n)
                        {
                            if (mineFeeld[row,col]<=0|| value<0)
                            {
                                continue;
                            }
                            mineFeeld[row, col] -= value;
                        }
                    }
                }
                //bool leftIsValid = colBomb - 1 >= 0;
                //bool rightIsValid = colBomb + 1 < n;
                //bool upIsValid = rowBomb - 1 >= 0;
                //bool downIsValod = rowBomb + 1 < n;
                //if (leftIsValid && upIsValid && mineFeeld[rowBomb - 1,colBomb - 1]>0)
                //{
                //    mineFeeld[rowBomb - 1, colBomb - 1] -= value;
                //}
                //if (upIsValid && mineFeeld[rowBomb - 1, colBomb] > 0)
                //{
                //    mineFeeld[rowBomb - 1, colBomb] -= value;
                //}
                //if (rightIsValid && upIsValid && mineFeeld[rowBomb - 1, colBomb + 1] > 0)
                //{
                //    mineFeeld[rowBomb - 1, colBomb + 1] -= value;
                //}
                //if (leftIsValid && mineFeeld[rowBomb, colBomb - 1] > 0)
                //{
                //    mineFeeld[rowBomb, colBomb - 1] -= value;
                //}
                //if (rightIsValid && mineFeeld[rowBomb, colBomb + 1] > 0)
                //{
                //    mineFeeld[rowBomb, colBomb + 1] -= value;
                //}
                //if (downIsValod && mineFeeld[rowBomb + 1, colBomb] > 0)
                //{
                //    mineFeeld[rowBomb + 1, colBomb] -= value;
                //}
                //if (leftIsValid && downIsValod && mineFeeld[rowBomb + 1, colBomb - 1] > 0)
                //{
                //    mineFeeld[rowBomb + 1, colBomb - 1] -= value;
                //}
                //if (rightIsValid && downIsValod && mineFeeld[rowBomb + 1, colBomb + 1] > 0)
                //{
                //    mineFeeld[rowBomb + 1, colBomb + 1] -= value;
                //}
            }

            int sum = 0;
            int count = 0;

            foreach (var cells in mineFeeld)
            {
                if (cells>0)
                {
                    sum += cells;
                    count++;
                }
            }

            Console.WriteLine($"Alive cells: {count}");
            Console.WriteLine($"Sum: {sum}");

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write(mineFeeld[row,col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
