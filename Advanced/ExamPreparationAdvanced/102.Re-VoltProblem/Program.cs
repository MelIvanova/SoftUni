using System;

namespace _102.Re_VoltProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int commandNums = int.Parse(Console.ReadLine());
            char[,] field = new char[size, size];
            int startRow = 0;
            int startCol = 0;

            for (int row = 0; row < size; row++)
            {
                string data = Console.ReadLine();
                char[] input = data.ToCharArray();

                for (int col = 0; col < size; col++)
                {
                    if (input[col] == 'f')
                    {
                        startRow = row;
                        startCol = col;
                        input[col] = '-';
                    }

                    field[row, col] = input[col];
                }

            }

            for (int i = 0; i < commandNums; i++)
            {
                string command = Console.ReadLine();
                int currRow = startRow;
                int currCol = startCol;
                switch (command)
                {
                    case "down":
                        currRow++;
                        if (!OutOfBowndery(currRow, currCol, size))
                        {
                            currRow = 0;
                        }

                        if (field[currRow, currCol] == 'T')
                        {
                            currRow = startRow;
                        }
                        else if (field[currRow, currCol] == 'B')
                        {
                            currRow++;
                            if (!OutOfBowndery(currRow, currCol, size))
                            {
                                currRow = 0;
                            }
                        }
                        break;
                    case "up":
                        currRow--;
                        if (!OutOfBowndery(currRow, currCol, size))
                        {
                            currRow = size - 1;
                        }

                        if (field[currRow, currCol] == 'T')
                        {
                            currRow = startRow;
                        }
                        else if (field[currRow, currCol] == 'B')
                        {
                            currRow--;
                            if (!OutOfBowndery(currRow, currCol, size))
                            {
                                currRow = size - 1;
                            }
                        }
                        break;
                    case "right":
                        currCol++;
                        if (!OutOfBowndery(currRow, currCol, size))
                        {
                            currCol = 0;
                        }

                        if (field[currRow, currCol] == 'T')
                        {
                            currCol = startCol;
                        }
                        else if (field[currRow, currCol] == 'B')
                        {
                            currCol++;
                            if (!OutOfBowndery(currRow, currCol, size))
                            {
                                currCol = 0;
                            }
                        }
                        break;
                    case "left":
                        currCol--;
                        if (!OutOfBowndery(currRow, currCol, size))
                        {
                            currCol = size - 1;
                        }

                        if (field[currRow, currCol] == 'T')
                        {
                            currCol = startCol;
                        }
                        else if (field[currRow, currCol] == 'B')
                        {
                            currCol--;
                            if (!OutOfBowndery(currRow, currCol, size))
                            {
                                currCol = size - 1;
                            }
                        }
                        break;
                }
                startCol = currCol;
                startRow = currRow;
                if (field[startRow, startCol] == 'F')
                {
                    Console.WriteLine("Player won!");
                    field[startRow, startCol] = 'f';
                    break;
                }

                if (i == commandNums - 1)
                {
                    field[startRow, startCol] = 'f';
                    Console.WriteLine("Player lost!");
                }
            }

            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    Console.Write(field[row, col]);
                }
                Console.WriteLine();
            }
        }

        private static bool OutOfBowndery(int startRow, int startCol, int size)
        {
            return startRow >= 0 && startRow < size && startCol >= 0 && startCol < size;
        }
    }
}
