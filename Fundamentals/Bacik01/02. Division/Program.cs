using System;

namespace _02._Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int num = 0;

            if(number % 10 == 0)
            {
                num = 10;
                Console.WriteLine($"The number is divisible by {num}");
            }
            else if (number % 7 == 0)
            {
                num = 7;
                Console.WriteLine($"The number is divisible by {num}");
            }
            else if (number % 6 == 0)
            {
                num = 6;
                Console.WriteLine($"The number is divisible by {num}");
            }
            else if (number % 3 == 0)
            {
                num = 3;
                Console.WriteLine($"The number is divisible by {num}");
            }
            else if (number % 2 == 0)
            {
                num = 2;
                Console.WriteLine($"The number is divisible by {num}");
            }
            else
            {
                Console.WriteLine("Not divisible");
            }
        }
    }
}
