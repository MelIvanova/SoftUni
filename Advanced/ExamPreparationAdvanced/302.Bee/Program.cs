using System;

namespace _302.Bee
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            char[,] garden = new char[size, size];
            int beeRow = 0;
            int beeCol = 0;

            for (int row = 0; row < size; row++)
            {
                char[] data = Console.ReadLine().ToCharArray();

                for (int col = 0; col < size; col++)
                {
                    if (data[col] == 'B')
                    {
                        beeRow = row;
                        beeCol = col;
                    }

                    garden[row, col] = data[col];
                }
            }

            int polinationedFlowers = 0;
            string command = Console.ReadLine();

            while (command != "End")
            {
                garden[beeRow, beeCol] = '.';
                beeRow = MoveRow(beeRow, command);
                beeCol = MoveCol(beeCol, command);

                if (!InBowndery(beeRow, beeCol, size))
                {
                    Console.WriteLine("The bee got lost!");
                    break;
                }

                
                if (garden[beeRow, beeCol] == 'O')
                {
                    garden[beeRow, beeCol] = '.';
                    beeRow = MoveRow(beeRow, command);
                    beeCol = MoveCol(beeCol, command);
                }

                if (garden[beeRow, beeCol] == 'f')
                {
                    polinationedFlowers++;
                }

                garden[beeRow, beeCol] = 'B';
                command = Console.ReadLine();
            }


            if (polinationedFlowers >= 5)
            {
                Console.WriteLine($"Great job, the bee managed to pollinate {polinationedFlowers} flowers!");
            }
            else
            {
                Console.WriteLine($"The bee couldn't pollinate the flowers, she needed " +
                    $"{5-polinationedFlowers} flowers more");
            }

            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    Console.Write(garden[row, col]);
                }
                Console.WriteLine();
            }
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
            if (command=="up")
            {
                return beeRow - 1;
            }
            else if (command =="down")
            {
                return beeRow + 1;
            }

            return beeRow;
        }

        static bool InBowndery(int row, int col, int size)
        {
            return row >= 0 && row < size && col >= 0 && col < size;
        }
    }
}
