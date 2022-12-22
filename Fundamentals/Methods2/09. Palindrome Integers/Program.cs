using System;

namespace _09._Palindrome_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();

            while (number != "END")
            {
                Palindrome(number);
                number = Console.ReadLine();
            }
        }

        private static void Palindrome(string number)
        {
            bool isPalindrome = false;
            if (number.Length==1)
            {
                Console.WriteLine("true");
                return;
            }

            for (int i = 0; i < number.Length / 2; i++)
            {
                if (number[i] != number[number.Length - 1 - i])
                {
                    Console.WriteLine("false");
                    isPalindrome = false;
                    break;
                }
                else
                {
                    isPalindrome = true;
                }
            }

            if (isPalindrome)
            {
                Console.WriteLine("true");
            }

        }
    }
}
