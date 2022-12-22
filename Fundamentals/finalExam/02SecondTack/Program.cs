using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02SecondTack
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"!([A-Z][a-z]{2,})!:\[([A-Za-z]{8,})\]";
            Regex regex = new Regex(pattern);
            int num = int.Parse(Console.ReadLine());
            

            for (int i = 0; i < num; i++)
            {
                string message = Console.ReadLine();
                Match match = regex.Match(message);
                string commands = string.Empty;
                string decodeMessage = string.Empty;
                List<int> shifer = new List<int>();

                if (match.Success)
                {
                    commands = match.Groups[1].Value;
                    decodeMessage = match.Groups[2].Value;
                    foreach (var letter in decodeMessage)
                    {
                        shifer.Add(letter);
                    }
                    Console.WriteLine($"{commands}: {string.Join(" ", shifer)}");
                }
                else
                {
                    Console.WriteLine("The message is invalid");
                }
            }

        }
    }
}
