using System;

namespace Mario
{
    class Program
    {
        static void Main(string[] args)
        {
            int lives = int.Parse(Console.ReadLine());
            int size = int.Parse(Console.ReadLine());

            char[,] matrix = new char[size, size];
            int mRow = 0;
            int mCol = 0;

            for (int row = 0; row < size; row++)
            {
                char[] data = Console.ReadLine().ToCharArray();

                for (int col = 0; col < size; col++)
                {
                    if (data[col] == 'M')
                    {
                        mRow = row;
                        mCol = col;
                        data[col] = '-';
                    }

                    matrix[row, col] = data[col];
                }
            }

            bool marioIsDead = false;

            while (lives > 0)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                char command = char.Parse(input[0]);
                int bRow = int.Parse(input[1]);
                int bCol = int.Parse(input[2]);

                lives--;

                matrix[bRow, bCol] = 'B';

                int cRow = RowInBowndery(mRow, command);
                int cCol = ColInBowndery(mCol, command);

                if (InTheFeeld(cRow, cCol, size))
                {
                    mRow = cRow;
                    mCol = cCol;

                    if (matrix[mRow, mCol] == 'B')
                    {
                        lives -= 2;

                        if (lives <= 0)
                        {
                            marioIsDead = true;
                            matrix[mRow, mCol] = 'X';
                            break;
                        }
                        else
                        {
                            matrix[mRow, mCol] = '-';
                        }
                    }
                    else if (matrix[mRow, mCol] == 'P')
                    {
                        matrix[mRow, mCol] = '-';
                        break;
                    }
                }

            }

            if (marioIsDead)
            {
                Console.WriteLine($"Mario died at {mRow};{mCol}.");
            }
            else
            {
                Console.WriteLine($"Mario has successfully saved the princess! Lives left: {lives}");
            }

            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }

        private static bool InTheFeeld(int cRow, int cCol, int size)
        {
            return cRow >= 0 && cRow < size && cCol >= 0 && cCol < size;
        }

        private static int ColInBowndery(int mCol, char command)
        {
            if (command == 'A')
            {
                return mCol -1;
            }
            if (command == 'D')
            {
                return mCol + 1;
            }

            return mCol;
        }

        private static int RowInBowndery(int mRow, char command)
        {
            if (command == 'W')
            {
               return mRow - 1;
            }
            if (command == 'S')
            {
              return  mRow + 1;
            }

            return mRow;
        }
    }
}
