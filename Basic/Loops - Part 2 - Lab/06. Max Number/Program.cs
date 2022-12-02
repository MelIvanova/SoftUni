using System;

namespace _06._Max_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()), i = 1, max = int.MinValue;
            while (i<=n)
            {
                int number = int.Parse(Console.ReadLine());
                if (max<number)
                {
                    max = number;
                }
                i++;
            }
            Console.WriteLine(max);
            
        }
    }
}
