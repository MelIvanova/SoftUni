using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _102EmojiDetector
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"([:]{2}[A-Z][a-z]{2,}[:]{2})|([*]{2}[A-Z][a-z]{2,}[*]{2})";
            Regex regex = new Regex(pattern);
            string input = Console.ReadLine();
            string filter = "0123456789";
            char []num = input.Where(c => filter.Contains(c)).ToArray();
            int coolThreshold = 1;

            foreach (char n in num)
            {
                coolThreshold *= int.Parse(n.ToString());
            }

            Console.WriteLine($"Cool threshold: {coolThreshold}");

            MatchCollection emojis = regex.Matches(input);
            Console.WriteLine($"{emojis.Count} emojis found in the text. The cool ones are:");

            foreach (Match emoji in emojis)
            {
                bool isCool = CoolCalcolator(emoji, coolThreshold);
                if (isCool)
                {
                    Console.WriteLine(emoji);
                }
            }

        }

        private static bool CoolCalcolator(Match emoji, int coolThreshold)
        {
            bool isCool = false;

            string pattern = @"[A-Z][a-z]+";
            Regex leterRegex = new Regex(pattern);
            Match name = leterRegex.Match(emoji.Value);
            int cool = 0;

            foreach (var item in name.Value)
            {
                 cool += (int)(item);
            }

            if (cool>=coolThreshold)
            {
                isCool = true;
            }

            return isCool;
        }
    }
}
