using System;

namespace _05._Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                int sum = 1;
                while (i !=0)
                {
                    sum += i % 10;
                    sum = sum / 10;
                }
                if (sum==5)
                {
                    Console.WriteLine("True");
                }
                else
                {
                    Console.WriteLine("False");
                }
            }
        }
    }
}
