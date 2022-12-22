using System;

namespace L01._Sign_of_Integer_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            WhatIsTheNumber(number);
        }

        private static void WhatIsTheNumber(int number)
        {
            if (number!=0)
            {
                if (number<0)
                {
                    Console.WriteLine($"The number {number} is negative.");
                }
                else
                {
                    Console.WriteLine($"The number {number} is positive.");
                }
            }
            else
            {
                Console.WriteLine("The number 0 is zero.");
            }
        }
    }
}
