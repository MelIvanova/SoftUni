using System;
using System.Linq;

namespace U9._Miner
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            string[] commands = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            char[,] mine = new char[size, size];
            int coal = 0;
            int startRow = 0;
            int startCol = 0;

            for (int row = 0; row < size; row++)
            {
                char[] input = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).
                    Select(char.Parse).ToArray();

                for (int col = 0; col < size; col++)
                {
                    mine[row, col] = input[col];

                    if (mine[row,col]=='c')
                    {
                        coal++;
                    }
                    if (mine[row,col]=='s')
                    {
                        startRow = row;
                        startCol = col;
                    }
                }
            }

            bool gameOver = false;

            for (int i = 0; i < commands.Length; i++)
            {
                string command = commands[i];
                switch (command)
                {
                    case"left":
                        startCol--;
                        if (IsInRange(size, startCol, startRow))
                        {
                            if (mine[startRow, startCol] == 'c')
                            {
                                coal--;
                                mine[startRow, startCol] = '*';
                            }
                        }
                        else
                        {
                            startCol++;
                        }
                        break;
                    case"right":
                        startCol++;
                        if (IsInRange(size, startCol, startRow))
                        {
                            if (mine[startRow, startCol] == 'c')
                            {
                                coal--;
                                mine[startRow, startCol] = '*';
                            }
                        }
                        else
                        {
                            startCol--;
                        }
                        break;
                    case"up":
                        startRow--;
                        if (IsInRange(size, startCol, startRow))
                        {
                            if (mine[startRow, startCol] == 'c')
                            {
                                coal--;
                                mine[startRow, startCol] = '*';
                            }
                        }
                        else
                        {
                            startRow++;
                        }
                        break;
                    case"down":
                        startRow++;
                        if (IsInRange(size, startCol, startRow))
                        {
                            if (mine[startRow, startCol] == 'c')
                            {
                                coal--;
                                mine[startRow, startCol] = '*';
                            }
                        }
                        else
                        {
                            startRow--;
                        }
                        break;
                }

                if (mine[startRow, startCol] == 'e')
                {
                    gameOver = true;
                    break;
                }

                if (coal == 0)
                {
                    Console.WriteLine($"You collected all coals! ({startRow}, {startCol})");
                    return;
                }
            }

            if (gameOver)
            {
                Console.WriteLine($"Game over! ({startRow}, {startCol})");
            }
            else
            {
                Console.WriteLine($"{coal} coals left. ({startRow}, {startCol})");
            }
        }

        private static bool IsInRange(int size, int startCol, int startRow)
        {
            return startCol>=0 && startCol<size && startRow>=0 && startRow< size;
        }
    }
}
