using System;

namespace _07._Min_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()), i = 1, min = int.MaxValue;
            while (i <= n)
            {
                int number = int.Parse(Console.ReadLine());
                if (min > number)
                {
                    min = number;
                }
                i++;
            }
            Console.WriteLine(min);
        }
    }
}
