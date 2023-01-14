using System;

namespace _502.DangerousFloor
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] board = new string[8, 8];

            for (int row = 0; row < 8; row++)
            {
                string [] data = Console.ReadLine().Split(',');

                for (int col = 0; col < 8; col++)
                {
                    board[row, col] = data[col];
                }
            }

            string location = Console.ReadLine();

            while (location!="END")
            {
                string pease = location[0].ToString();
                int startRow = int.Parse(location[1].ToString());
                int startCol = int.Parse(location[2].ToString());
                int finishRow = int.Parse(location[4].ToString());
                int finishCol = int.Parse(location[5].ToString());

                if (!(board[startRow,startCol] == pease))
                {
                    Console.WriteLine("There is no such a piece!");
                    location = Console.ReadLine();
                    continue;
                }
                else
                {
                    if (ValideMove(location))
                    {
                        if (InBowndery(finishRow,finishCol))
                        {
                            board[startRow, startCol] = "x";
                            board[finishRow, finishCol] = pease;
                            location = Console.ReadLine();
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("Move go out of board!");
                            location = Console.ReadLine();
                            continue;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid move!");
                        location = Console.ReadLine();
                        continue;
                    }
                }
            }


        }

        private static bool InBowndery(int finishRow, int finishCol)
        {
            return finishCol >= 0 && finishCol < 8 && finishRow >= 0 && finishRow < 8;
        }

        private static bool ValideMove(string location)
        {
            string pease = location[0].ToString();
            int startRow = int.Parse(location[1].ToString());
            int startCol = int.Parse(location[2].ToString());
            int finishRow = int.Parse(location[4].ToString());
            int finishCol = int.Parse(location[5].ToString());

            switch (pease)
            {
                case "K":
                    return finishRow == startRow + 1 || finishRow == startRow - 1 ||
                        finishCol == startCol + 1 || finishCol == startCol - 1;
                case "R":
                    return finishCol == startCol && finishRow != startRow ||
                        finishRow == startRow && finishCol != startCol;
                case "B":
                    return finishCol != startCol && finishRow != startRow;
                case "Q":
                    return true;
                case "P":
                    return startCol == finishCol && finishRow == startRow - 1;
                default:
                    return false;
            }
        }
    }
}
