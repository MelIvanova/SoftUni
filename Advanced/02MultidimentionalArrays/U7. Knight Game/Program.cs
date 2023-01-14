using System;

namespace U7._Knight_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] chess = new char[n, n];

            for (int row = 0; row < n; row++)
            {
                string input = Console.ReadLine();
                for (int col = 0; col < n; col++)
                {
                    chess[row, col] = input[col];
                }
            }

            
            bool isFighting = true;
            int count = 0;

            while (isFighting)
            {
                int hits = 0;
                int bestHits = 0;
                int rowIndex = 0;
                int colIndex = 0;

                for (int row = 0; row < n; row++)
                {
                    for (int col = 0; col < n; col++)
                    {
                        if (chess[row,col] == 'K')
                        {
                            hits = KnightHit(row, col, chess, n);
                        }
                        if (hits>bestHits)
                        {
                            bestHits = hits;
                            rowIndex = row;
                            colIndex = col;
                        }

                    }
                }

                if (bestHits == 0)
                {
                    isFighting = false;
                }
                else
                {
                    chess[rowIndex, colIndex] = '0';
                    count++;
                }
            }

            Console.WriteLine(count);

        }

        private static int KnightHit(int row, int col, char[,] chess, int n)
        {
            int hits = 0;
            if (row+2<n && col+1<n)
            {
                if (chess[row+2, col+1] == 'K')
                {
                    hits++;
                }
            }
            if (row + 2 < n && col - 1 >= 0)
            {
                if (chess[row + 2, col - 1] == 'K')
                {
                    hits++;
                }
            }
            if (row - 1 >= 0 && col - 2 >= 0)
            {
                if (chess[row - 1, col - 2] == 'K')
                {
                    hits++;
                }
            }
            if (row - 1 >= 0 && col + 2 < n)
            {
                if (chess[row - 1, col + 2] == 'K')
                {
                    hits++;
                }
            }
            if (row + 1 < n && col + 2 < n)
            {
                if (chess[row + 1, col + 2] == 'K')
                {
                    hits++;
                }
            }
            if (row + 1 < n && col - 2 >=0)
            {
                if (chess[row + 1, col - 2] == 'K')
                {
                    hits++;
                }
            }
            if (row - 2 >= 0 && col + 1 < n)
            {
                if (chess[row - 2, col + 1] == 'K')
                {
                    hits++;
                }
            }
            if (row - 2 >= 0 && col - 1 >= 0)
            {
                if (chess[row - 2, col - 1] == 'K')
                {
                    hits++;
                }
            }

            return hits;
        }
    }
}
