using System;

namespace _02._Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            VowelsCounting(word);
        }

        private static void VowelsCounting(string word)
        {
            int count = 0;

            for (int i = 0; i < word.Length; i++)
            {
                switch (word[i])
                {
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u':
                    case 'A':
                    case 'E':
                    case 'I':
                    case 'O':
                    case 'U':
                        count++;
                        break;
                }
            }

            Console.WriteLine(count);
        }
    }
}
