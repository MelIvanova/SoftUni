using System;
using System.Runtime.InteropServices;

namespace _12._English_Name_of_Last_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            if (number == 0 || number == 1)
            {
                Console.WriteLine("False");
            }
            else
            {
                Console.WriteLine(IsPrime(number));
            }
        }

         static bool IsPrime(long num)
        {
            bool isPrime = true;
            int couter = 2;
            while (couter<=Math.Sqrt(num))
            {
                if (num%couter == 0)
                {
                    isPrime = false;
                    break;
                }
                couter++;
            }
            return isPrime;
        }
    }
}
