using System;

namespace _03._Zig_Zag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            string[] arrOne = new string[lines];
            string[] arrTwo = new string[lines];

            for (int i = 1; i <= lines; i++)
            {
                string[] curr = Console.ReadLine().Split();

                if (i%2!=0)
                {
                    arrOne[i - 1] = curr[0];
                    arrTwo[i - 1] = curr[1];
                }
                else
                {
                    arrOne[i - 1] = curr[1];
                    arrTwo[i - 1] = curr[0];
                }
            }

            Console.WriteLine(string.Join(" ",arrOne));
            Console.WriteLine(string.Join(" ", arrTwo));
        }
    }
}
