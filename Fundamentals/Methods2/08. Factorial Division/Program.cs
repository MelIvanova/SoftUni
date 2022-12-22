using System;

namespace _08._Factorial_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            FactorialDivide(firstNum, secondNum);
        }

        private static void FactorialDivide(int firstNum, int secondNum)
        {
            long firstSum = firstNum;
            for (int i = firstNum - 1; i > 0; i--)
            {
                firstSum *= i;
            }

            long secondSum = secondNum;
            for (int i = secondNum - 1; i > 0; i--)
            {
                secondSum *= i;
            }

            double result = firstSum*1.0 / secondSum;

            Console.WriteLine($"{result:F2}");
        }
    }
}
