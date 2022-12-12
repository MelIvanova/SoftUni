using System;

namespace _06._PrintSqare
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            PrintSqare(count);
        }
       
        private static void PrintSqare(int num)
        {

            PrintTopBottom(num);
            PrintMiddle(num);
            Console.WriteLine();
            PrintMiddle(num);
            Console.WriteLine();
            PrintTopBottom(num);
        }

    private static void PrintMiddle(int num)
    {
        Console.Write('-');
        for (int i = 1; i < num; i++)
        {
            Console.Write("\\/");
        }
            Console.Write('-');
        }

    private static void PrintTopBottom(int num)
    {
        Console.WriteLine(new string('-', num * 2));
    }
}
}
