using System;

namespace _06._Middle_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            MiddleCharacters(word);
        }

        private static void MiddleCharacters(string word)
        {
            string result = "";

            if (word.Length%2==0)
            {
                int indexEven = (int)word.Length / 2;
                result = word[indexEven-1].ToString() + word[indexEven].ToString();
            }
            else
            {
                int indexOdd = (int)word.Length / 2;
                result = word[indexOdd].ToString();
            }

            Console.WriteLine(result);
        }
    }
}
