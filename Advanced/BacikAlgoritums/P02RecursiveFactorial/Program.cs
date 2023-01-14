using System;

namespace P02RecursiveFactorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int factorialNumber = int.Parse(Console.ReadLine());
            Console.WriteLine(FactorialSum(factorialNumber));
        }

        private static long FactorialSum(int factorialNumber)
        {
            if (factorialNumber == 1)
            {
                return 1;
            }

            return factorialNumber * FactorialSum(factorialNumber-1);
        }
    }
}
