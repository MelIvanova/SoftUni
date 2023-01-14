using System;

namespace _702.Selling
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            char[,] bakery = new char[size, size];
            int rowS = 0;
            int colS = 0;
            int rowOne = 0;
            int rowTwo = 0;
            int colOne = 0;
            int colTwo = 0;
            int foundO = 0;

            for (int row = 0; row < size; row++)
            {
                char[] data = Console.ReadLine().ToCharArray();

                for (int col = 0; col < size; col++)
                {
                    if (data[col]=='S')
                    {
                        rowS = row;
                        colS = col;
                        data[col] = '-';
                    }
                    else if (data[col] == 'O' && foundO ==0)
                    {
                        rowOne = row;
                        colOne = col;
                        foundO++;
                    }
                    else if(data[col] == 'O' && foundO == 1)
                    {
                        rowTwo = row;
                        colTwo = col;
                    }

                    bakery[row, col] = data[col];
                }
            }

            int money = 0;

            while (money < 50)
            {
                string command = Console.ReadLine();
                rowS = MoveRow(rowS, command);
                colS = MoveCol(colS, command);

                if (InBowndery(rowS, colS, size))
                {
                    if (bakery[rowS, colS] == 'O')
                    {
                        if (rowOne == rowS && colOne == colS)
                        {
                            rowS = rowTwo;
                            colS = colTwo;
                        }
                        else if (rowTwo == rowS && colTwo == colS)
                        {
                            rowS = rowOne;
                            colS = colOne;
                        }

                        bakery[rowTwo, colTwo] = '-';
                        bakery[rowOne, colOne] = '-';
                    }

                    int spend;

                    if (int.TryParse(bakery[rowS, colS].ToString(), out  spend))
                    {
                        money += spend;
                        bakery[rowS, colS] = '-';
                    }
                }
                else
                {
                    Console.WriteLine("Bad news, you are out of the bakery.");
                    break;
                }
            }

            if (money >= 50)
            {
                bakery[rowS, colS] = 'S';
                Console.WriteLine("Good news! You succeeded in collecting enough money!");
            }

            Console.WriteLine($"Money: {money}");

            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    Console.Write(bakery[row, col]);
                }
                Console.WriteLine();
            }
        }


        static bool InBowndery(int row, int col, int size)
        {
            return row >= 0 && row < size && col >= 0 && col < size;
        }


        private static int MoveCol(int beeCol, string command)
        {
            if (command == "left")
            {
                return beeCol - 1;
            }
            else if (command == "right")
            {
                return beeCol + 1;
            }

            return beeCol;
        }

        private static int MoveRow(int beeRow, string command)
        {
            if (command == "up")
            {
                return beeRow - 1;
            }
            else if (command == "down")
            {
                return beeRow + 1;
            }

            return beeRow;
        }

    }
}
