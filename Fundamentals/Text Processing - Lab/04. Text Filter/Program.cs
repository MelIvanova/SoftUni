using System;

namespace _04._Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine().Split(", ");
            string text = Console.ReadLine();
            bool exit = true;

            while (exit)
            {
                for (int i = 0; i < bannedWords.Length; i++)
                {
                    int lenght = bannedWords[i].Length;
                    string replace = new string('*', lenght);
                    text = text.Replace(bannedWords[i], replace);
                   
                    if (!text.Contains(bannedWords[bannedWords.Length-1]))
                    {
                        exit = false;
                    }
                }
            }
            Console.WriteLine(text);
        }
    }
}
