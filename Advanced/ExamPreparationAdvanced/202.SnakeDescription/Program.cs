using System;

namespace _202.SnakeDescription
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            char[,] snakeTerritory = new char[size, size];
            int snakeRow = 0;
            int snakeCol = 0;
            int lairOneRow = 0;
            int lairOneCol = 0;
            int lairTwoRow = 0;
            int lairTwoCol = 0;
            int findLaits = 0;

            for (int row = 0; row < size; row++)
            {
                string input = Console.ReadLine();
                char[] data = input.ToCharArray();
                for (int col = 0; col < size; col++)
                {
                    if (data[col]=='S')
                    {
                        snakeRow = row;
                        snakeCol = col;
                        data[col] = '.';
                    }

                    if (data[col] == 'B' && findLaits == 0)
                    {
                        lairOneRow = row;
                        lairOneCol = col;
                        findLaits++;
                    }
                    else if (data[col] == 'B' && findLaits == 1)
                    {
                        lairTwoRow = row;
                        lairTwoCol = col;
                    }

                    snakeTerritory[row, col] = data[col];
                }
            }

            int foodQuantity = 0;

            while (foodQuantity != 10)
            {
                string command = Console.ReadLine();

                switch (command)
                {
                    case"up":
                        snakeRow--;
                        break;
                    case"down":
                        snakeRow++;
                        break;
                    case"right":
                        snakeCol++;
                        break;
                    case"left":
                        snakeCol--;
                        break;
                }

                if (InBowndery(snakeRow, snakeCol, size))
                {
                    if (snakeTerritory[snakeRow,snakeCol]=='B')
                    {
                        if (lairOneRow == snakeRow && lairOneCol == snakeCol)
                        {
                            snakeRow = lairTwoRow;
                            snakeCol = lairTwoCol;
                        }
                        else if (lairTwoRow == snakeRow && lairTwoCol == snakeCol)
                        {
                            snakeRow = lairOneRow;
                            snakeCol = lairOneCol;
                        }

                        snakeTerritory[lairTwoRow, lairTwoCol] = '.';
                        snakeTerritory[lairOneRow, lairOneCol] = '.';
                    }
                    else if (snakeTerritory[snakeRow, snakeCol] == '*')
                    {
                        foodQuantity++;
                    }
                    snakeTerritory[snakeRow, snakeCol] = '.';
                }
                else
                {
                    Console.WriteLine("Game over!");
                    break;
                }

                if (foodQuantity==10)
                {
                    Console.WriteLine("You won! You fed the snake.");
                    snakeTerritory[snakeRow, snakeCol] = 'S';
                    break;
                }
            }

            Console.WriteLine($"Food eaten: {foodQuantity}");

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(snakeTerritory[i,j]);
                }
                Console.WriteLine();
            }

        }

        static bool InBowndery(int row, int col, int size) 
        {
            return row >= 0 && row < size && col >= 0 && col < size;
        }
    }
}
