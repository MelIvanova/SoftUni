using System;

namespace _02._Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            int result = CountOfVowels(input);
            Console.WriteLine(result);
        }

         static int CountOfVowels(string input)
        {
            int result = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i]=='a'|| input[i] == 'i' || input[i] == 'o' || input[i] == 'u' || input[i] == 'e')
                {
                    result++;
                }
               
            }

            return result;
        }
    }
}
