using System;

namespace _06._Vowels_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            int valueLetters = 0;
            
            for(int i=0; i < word.Length; i++)
            {
                char currentChar = word[i];
                switch(currentChar)
                {
                    case 'a':
                        valueLetters += 1;
                        break;
                    case 'e':
                        valueLetters += 2;
                        break;
                    case 'i':
                        valueLetters += 3;
                        break;
                    case 'o':
                        valueLetters += 4;
                        break;
                    case 'u':
                        valueLetters += 5;
                        break;
                }
                

                
            }

            Console.WriteLine(valueLetters);
        }
    }
}
