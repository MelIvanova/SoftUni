using System;
using System.Collections.Generic;

namespace _10._Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
           int result = GetMultipleOfEvenAndOdds(input);
            Console.WriteLine(result);
        }

         static int GetMultipleOfEvenAndOdds(int number)
        {
            int evenSum = GetSumOfEvenDigits(number);
            int oddSum = GetSumOfOddDigits(number);
            return evenSum*oddSum;
        }

        static int GetSumOfOddDigits(int num)
        {
            int number = Math.Abs(num);
            List<int> listOfInts = new List<int>();
            int result = 0;
            while (number > 0)
            {
                listOfInts.Add(number % 10);
                number = number / 10;
            }
            for (int i = 0; i < listOfInts.Count; i++)
            {
                if (listOfInts[i]%2 != 0)
                {
                    result += listOfInts[i];
                }
            }
            return result;
        }

        static int GetSumOfEvenDigits(int num)
        {
            int number = Math.Abs(num);
            List<int> listOfInts = new List<int>();
            int result = 0;
            while (number > 0)
            {
                listOfInts.Add(number % 10);
                number = number / 10;
            }
            for (int i = 0; i < listOfInts.Count; i++)
            {
                if (listOfInts[i] % 2 == 0)
                {
                    result += listOfInts[i];
                }
            }
            return result;
        }
    }
}
