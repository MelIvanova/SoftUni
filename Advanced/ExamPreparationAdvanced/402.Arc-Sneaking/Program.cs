using System;

namespace _402.Arc_Sneaking
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            string colData = Console.ReadLine();
            char[,] feald = new char[rows, colData.Length];
            int rowSam = 0;
            int colSam = 0;

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < colData.Length; col++)
                {
                    if (colData[col] == 'S')
                    {
                        rowSam = row;
                        colSam = col;
                    }

                    feald[row, col] = colData[col];
                }
                if (row != rows - 1)
                {
                    colData = Console.ReadLine();
                }

            }

            char[] command = Console.ReadLine().ToCharArray();

            for (int i = 0; i < command.Length; i++)
            {
                feald[rowSam, colSam] = '.';

                feald = EnemyMoves(feald);

                if (EnemyOnTheRow(rowSam, colSam, feald))
                {
                    feald[rowSam, colSam] = 'X';
                    Console.WriteLine($"Sam died at {rowSam}, {colSam}");
                    break;
                }

                switch (command[i])
                {
                    case 'U':
                        rowSam--;
                        break;
                    case 'D':
                        rowSam++;
                        break;
                    case 'L':
                        colSam--;
                        break;
                    case 'R':
                        colSam++;
                        break;
                    case 'W':
                        break;
                }

                for (int j = 0; j < feald.GetLength(1); j++)
                {
                    if (feald[rowSam, j] == 'N')
                    {
                        feald[rowSam, j] = 'X';
                        Console.WriteLine("Nikoladze killed!");
                        i = command.Length - 1;
                        feald[rowSam, colSam] = 'S';
                    }
                }
            }

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < feald.GetLength(1); col++)
                {
                    Console.Write(feald[row,col]);
                }
                Console.WriteLine();
            }
        }

        private static bool EnemyOnTheRow(int rowSam, int colSam, char[,] feald)
        {
            for (int i = 0; i < feald.GetLength(1); i++)
            {
                if (i<colSam && feald[rowSam,i]=='b')
                {
                    return true;
                }

                if (i > colSam && feald[rowSam, i] == 'd')
                {
                    return true;
                }
            }

            return false;
        }

        private static char[,] EnemyMoves(char[,] feald)
        {
            for (int row = 0; row < feald.GetLength(0); row++)
            {
                for (int col = 0; col < feald.GetLength(1); col++)
                {
                    if (feald[row, col] == 'b')
                    {
                        int bCol = col+1;
                        if (Inside(bCol, feald.GetLength(1)))
                        {
                            feald[row, col] = '.';
                            feald[row, bCol] = 'b';
                            col = bCol;
                        }
                        else
                        {
                            feald[row, col] = 'd';
                        }
                        break;
                    }
                    else if (feald[row, col] == 'd')
                    {
                        int dCol = col - 1;
                        if (Inside(dCol, feald.GetLength(1)))
                        {
                            feald[row, col] = '.';
                            feald[row, dCol] = 'd';
                            col = dCol;
                        }
                        else
                        {
                            feald[row, col] = 'b';
                        }
                        break;
                    }
                }
            }

            return feald;
        }

        private static bool Inside(int col, int v)
        {
            return col >= 0 && col < v;
        }
    }
}
