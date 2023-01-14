using System;


namespace _001.FirstProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            int lives = int.Parse(Console.ReadLine());
            int size = int.Parse(Console.ReadLine());
            char[] data = Console.ReadLine().ToCharArray();
            char[,] feald = new char[size, data.Length];
            int rowM = 0;
            int colM = 0;

            for (int row = 0; row < size; row++)
            {
                

                for (int col = 0; col < size; col++)
                {
                    if (data[col]=='M')
                    {
                        rowM = row;
                        colM = col;
                    }

                    feald[row, col] = data[col];
                }

                if (row!=size-1)
                {
                    data = Console.ReadLine().ToCharArray();
                }
            }

            while (lives>0)
            {
                feald[rowM, colM] = '-';
                string[] commands = Console.ReadLine().Split();
                string command = commands[0];
                int bowerRow = int.Parse(commands[1]);
                int bowerCol = int.Parse(commands[2]);

                feald[bowerRow, bowerCol] = 'B';

                int currCol = MoveCol(colM, command);
                int currRow = MoveRow(rowM, command);
                lives--;

                if (!InBowndery(currRow, currCol, size))
                {
                    continue;
                }
                else
                {
                    rowM = currRow;
                    colM = currCol;

                    if (feald[rowM, colM]=='B')
                    {
                        lives-=2;
                        if (lives <= 0)
                        {
                            feald[rowM, colM] = 'X';
                            Console.WriteLine($"Mario died at {rowM};{colM}.");
                            break;
                        }
                        else
                        {
                            feald[rowM, colM] = 'M';
                            continue;
                        }
                    }
                    else if (feald[rowM, colM] == 'P')
                    {
                        Console.WriteLine($"Mario has successfully saved the princess! Lives left: {lives}");
                        feald[rowM, colM] = '-';
                        break;
                    }
                }
            }

            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    Console.Write(feald[row, col]);
                }
                Console.WriteLine();
            }
        }

        static bool InBowndery(int row, int col, int size)
        {
            return row >= 0 && row < size && col >= 0 && col < size;
        }

        private static int MoveCol(int col, string command)
        {
            if (command == "A")
            {
                return col - 1;
            }
            else if (command == "D")
            {
                return col + 1;
            }

            return col;
        }

        private static int MoveRow(int row, string command)
        {
            if (command == "W")
            {
                return row - 1;
            }
            else if (command == "S")
            {
                return row + 1;
            }

            return row;
        }
    }
}
