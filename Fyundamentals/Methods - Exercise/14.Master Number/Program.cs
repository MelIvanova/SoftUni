using System;
using System.Collections.Generic;

namespace _14.Master_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            IsPalindrome(number);
            SumOfDigits(number);
            ContainsEvenDigit(number);
            for (int i = 1; i <= number; i++)
            {
                if (IsPalindrome(i)&& SumOfDigits(i)&& ContainsEvenDigit(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

         static bool ContainsEvenDigit(int num)
        {
            bool isValid = false;
            int lastNum = 0;
            while (num>0)
            {
                lastNum = num % 10;
                num = num / 10;
                if (lastNum % 2 == 0)
                {
                    isValid = true;
                }
            }

            return isValid;
        }

         static bool SumOfDigits(int num)
        {
            bool isValid = false;
            int number = 0;
            int result = 0;
            while (num>0)
            {
               number = num % 10;
                num = num / 10;
                result += number;
            }
            if (result%7 == 0)
            {
                isValid = true;
            }

            return isValid;
        }

         static bool IsPalindrome(int num)
        {
            bool isValid = true;
            string number = num.ToString();
            for (int i = 0; i < number.Length/2; i++)
            {
                if (number[i] != number [number.Length -1 - i])
                {
                    isValid = false;
                    break;
                }
            }

            return isValid;
        }
    }
}
