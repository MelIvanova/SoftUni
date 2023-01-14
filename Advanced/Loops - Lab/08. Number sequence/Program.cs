using System;

namespace _08._Number_sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            //Max number:
            //Min number: 

            int n = int.Parse(Console.ReadLine());
            int max = int.MinValue;
            int min = int.MaxValue;
            for (int i = 1; i <= n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if(max<number)
                {
                    max = number;
                }
                if(min>number)
                {
                    min = number;
                }
            }
            Console.WriteLine($"Max number: {max}");
            Console.WriteLine($"Min number: {min}");
        }
    }
}
