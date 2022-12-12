using System;

namespace _03._Exact_Sum_of_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal counter = decimal.Parse(Console.ReadLine());
            decimal result = 0m;
            for (int i = 1; i <= counter; i++)
            {
                decimal numbers = decimal.Parse(Console.ReadLine());
                result += numbers;
            }
            Console.WriteLine($"{result}");
        }
    }
}
