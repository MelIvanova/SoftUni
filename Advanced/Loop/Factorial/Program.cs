using System;
using System.Numerics;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger  number = BigInteger.Parse(Console.ReadLine());
            Console.WriteLine(Factoriel(number));
        }

        static BigInteger Factoriel(BigInteger number)
        {
            BigInteger result = 1;

            for (BigInteger i = 1; i <= number; i++)
            {
                result *= i;
            }

            return result;
        }
    }
}
