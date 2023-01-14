using System;
using System.Collections.Generic;
using System.Linq;

namespace U10._Radioactive_Mutant_Vampire_Bunnies
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).
                Select(int.Parse).ToArray();
            int rows = size[0];
            int columns = size[1];
            char[,] bunnyLair = new char[rows, columns];
            int playRow = 0;
            int playCol = 0;

            for (int row = 0; row < rows; row++)
            {
                string input = Console.ReadLine();

                for (int col = 0; col < columns; col++)
                {
                    bunnyLair[row, col] = input[col];

                    if (bunnyLair[row, col] == 'P')
                    {
                        playRow = row;
                        playCol = col;
                        bunnyLair[row, col] = '.';
                    }
                }
            }

            string commands = Console.ReadLine();
            bool isDead = false;

            for (int i = 0; i < commands.Length; i++)
            {
                char move = commands[i];

                if (move == 'L')
                {
                    playCol--;
                    if (InLair(playRow, playCol, rows, columns))
                    {
                        bunnyLair = BunnyExpand(bunnyLair, rows, columns);
                    }
                    else
                    {
                        playCol++;
                        bunnyLair = BunnyExpand(bunnyLair, rows, columns);
                        break;
                    }
                }
                else if (move == 'R')
                {
                    playCol++;
                    if (InLair(playRow, playCol, rows, columns))
                    {
                        bunnyLair = BunnyExpand(bunnyLair, rows, columns);
                    }
                    else
                    {
                        playCol--;
                        bunnyLair = BunnyExpand(bunnyLair, rows, columns);
                        break;
                    }
                }
                else if (move == 'U')
                {
                    playRow--;
                    if (InLair(playRow, playCol, rows, columns))
                    {
                        bunnyLair = BunnyExpand(bunnyLair, rows, columns);
                    }
                    else
                    {
                        playRow++;
                        bunnyLair = BunnyExpand(bunnyLair, rows, columns);
                        break;
                    }
                }
                else if (move == 'D')
                {
                    playRow++;
                    if (InLair(playRow, playCol, rows, columns))
                    {
                        bunnyLair = BunnyExpand(bunnyLair, rows, columns);
                    }
                    else
                    {
                        playRow--;
                        bunnyLair = BunnyExpand(bunnyLair, rows, columns);
                        break;
                    }
                }

                if (bunnyLair[playRow,playCol]=='B')
                {
                    isDead = true;
                    break;
                }
            }

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < columns; col++)
                {
                    Console.Write(bunnyLair[row,col]);
                }
                Console.WriteLine();
            }

            if (isDead)
            {
                Console.WriteLine($"dead: {playRow} {playCol}");
            }
            else
            {
                Console.WriteLine($"won: {playRow} {playCol}");
            }
        }

        static char[,] BunnyExpand(char[,] bunnyLair, int rows, int columns)
        {
            List<int> index = new List<int>();
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < columns; col++)
                {
                    if (bunnyLair[row,col]=='B')
                    {
                        index.Add(row);
                        index.Add(col);
                    }
                }
            }

            for (int i = 0; i < index.Count; i+=2)
            {
                int bRow = index[i];
                int bCol = index[i + 1];
                if (bRow-1>=0)
                {
                    bunnyLair[bRow - 1, bCol] = 'B';
                }
                if (bRow + 1 < rows)
                {
                    bunnyLair[bRow + 1, bCol] = 'B';
                }
                if (bCol-1>=0)
                {
                    bunnyLair[bRow, bCol-1] = 'B';
                }
                if (bCol + 1 < columns)
                {
                    bunnyLair[bRow, bCol + 1] = 'B';
                }
            }
            
            return bunnyLair;
        }

        static bool InLair(int playRow, int playCol, int rows, int columns)
        {
            return playCol>=0 && playCol<columns && playRow>=0 && playRow<rows;
        }
    }
}
