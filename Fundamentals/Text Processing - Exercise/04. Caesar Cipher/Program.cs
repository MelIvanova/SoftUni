using System;

namespace _04._Caesar_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string income = Console.ReadLine();
            char[] input = income.ToCharArray();
            string result = "";

            for (int i = 0; i < input.Length; i++)
            {
                char temp = (char)(input[i] + 3);
                result += temp;
                
            }
            Console.WriteLine(result);
        }
    }
}
