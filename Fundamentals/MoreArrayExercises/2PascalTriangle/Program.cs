using System;

namespace _2PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            ulong[] currentRow = { 1, 1 };
            if (rows >= 1)
            {
                Console.WriteLine(1);
            }
            if (rows >= 2)
            {
                Console.WriteLine($"1 1");
            }

            for (int i = 3; i <= rows; i++)
            {
                ulong[] previousRow = currentRow;
                currentRow = new ulong[i];

                for (int j = 0; j < i; j++)
                {
                    if (j == 0 || j == currentRow.Length - 1)
                    {
                        currentRow[j] = 1;
                    }
                    else
                    {
                        currentRow[j] = previousRow[j - 1] + previousRow[j];
                    }  
                }

                Console.WriteLine(String.Join((" "), currentRow));
            }
        }
    }
}
