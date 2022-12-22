using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _302MirrorWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(@|#)[A-Za-z]{3,}\1\1[A-Za-z]{3,}\1";
            string text = Console.ReadLine();
            Regex regex = new Regex(pattern);
           

            MatchCollection words = regex.Matches(text);

            if (words.Count>0)
            {
                Console.WriteLine($"{words.Count} word pairs found!");
            }
            else
            {
                Console.WriteLine("No word pairs found!");
                Console.WriteLine("No mirror words!");
                return;
            }

            string wordPattern = @"[A-Za-z]{3,}";
            Regex wordRegex = new Regex(wordPattern);
            List<string> wordsToCheck = new List<string>();

            foreach (Match pairs in words)
            {
                MatchCollection extract = wordRegex.Matches(pairs.Value);
                for (int i = 0; i < extract.Count; i++)
                {
                    wordsToCheck.Add(extract[i].Value);
                }
                
            }

            List<string> mirrorWords = new List<string>();

            for (int i = 0; i < wordsToCheck.Count; i+=2)
            {
                char[] second = wordsToCheck[i + 1].ToCharArray().Reverse().ToArray();
                string secondWord = string.Join("", second);
                if (wordsToCheck[i]==secondWord)
                {
                    mirrorWords.Add(wordsToCheck[i]);
                    mirrorWords.Add(wordsToCheck[i+1]);
                }
            }

            if (mirrorWords.Count>0)
            {
                Console.WriteLine("The mirror words are:");

                for (int i = 0; i < mirrorWords.Count; i+=2)
                {
                    Console.Write($"{mirrorWords[i]} <=> {mirrorWords[i+1]}");
                    if (i<mirrorWords.Count-2)
                    {
                        Console.Write(", ");
                    }
                }
            }
            else
            {
                Console.WriteLine("No mirror words!");
            }
            
        }
    }
}
