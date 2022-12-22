using System;

namespace _07._NxN_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            MatrinNum(num);
        }

        private static void MatrinNum(int num)
        {
            for (int i = 0; i < num; i++)
            {
                int[] line = new int[num];

                for (int j = 0; j < num; j++)
                {
                    line[j] = num;
                }

                Console.WriteLine(string.Join(' ',line));
            }
        }
    }
}
