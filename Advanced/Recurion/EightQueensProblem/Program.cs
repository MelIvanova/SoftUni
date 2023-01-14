namespace EightQueensProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int queens = int.Parse(Console.ReadLine());
            string[,] bord = new string[queens, queens];
            int row = 0;
            int numberOfPatterns = GetQueens(bord, row);
            Console.WriteLine(numberOfPatterns);
        }

        private static int GetQueens(string[,] bord, int row)
        {
            if (row == bord.GetLength(0))
            {
                PrintQueens(bord);
                return 1;
            }

            int foundQueens = 0;

            for (int col = 0; col < bord.GetLength(1); col++)
            {
                if (IsSafe(bord, row, col))
                {
                    foundQueens++;
                    bord[row, col] = "Q";
                    GetQueens(bord, row + 1);
                    bord[row, col] = "-";
                }
            }
            return foundQueens;
        }

        private static bool IsSafe(string[,] bord, int row, int col)
        {
            for (int i = 1; i < bord.GetLength(0); i++)
            {
                if (row - i >= 0 && bord[row - i, col] == "Q")
                {
                    return false;
                }
                if (col - i >= 0 && bord[row, col - i] == "Q")
                {
                    return false;
                }
                if (row + i < bord.GetLength(0) && bord[row + i, col] == "Q")
                {
                    return false;
                }
                if (col + i < bord.GetLength(0) && bord[row, col + i] == "Q")
                {
                    return false;
                }
                if (col + i < bord.GetLength(0) && row + i < bord.GetLength(0) &&
                    bord[row + i, col + i] == "Q")
                {
                    return false;
                }
                if (col - i >= 0 && row + i < bord.GetLength(0) &&
                    bord[row + i, col - i] == "Q")
                {
                    return false;
                }
                if (col + i < bord.GetLength(0) && row - i >= 0 &&
                    bord[row - i, col + i] == "Q")
                {
                    return false;
                }
                if (col - i >= 0 && row - i >= 0 &&
                    bord[row - i, col - i] == "Q")
                {
                    return false;
                }
            }
            return true;
        }

        private static void PrintQueens(string[,] bord)
        {
            for (int row = 0; row < bord.GetLength(0); row++)
            {
                for (int col = 0; col < bord.GetLength(1); col++)
                {
                    if (bord[row, col] == "Q")
                    {
                        Console.Write(bord[row, col] + " ");
                    }
                    else
                    {
                        Console.Write("-" + " ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}