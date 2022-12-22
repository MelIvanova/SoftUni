using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _04._Star_Enigma
{
    class Program
    {
        static void Main(string[] args)
        {
            string patternKey = @"[starSTAR]";
            string codePattern = @"[^@\-!:>]*@([A-z]+)[^@\-!:>]*:(\d+)[^@\-!:>]*!(A|D)![^@\-!:>]*->(\d+)[^@\-!:>]*";

            Regex keyRegex = new Regex(patternKey);
            Regex codeRegex = new Regex(codePattern);

            int lines = int.Parse(Console.ReadLine());
            string messege = string.Empty;
            
            List<string> attackPlanets = new List<string>();
            List<string> destroyedPlanets = new List<string>();

            for (int i = 0; i < lines; i++)
            {
                messege = Console.ReadLine();
                MatchCollection key = keyRegex.Matches(messege);
                int decodeNum = key.Count;
                string planerName = string.Empty;
                string attackType = string.Empty;
                StringBuilder decriptedMessege = new StringBuilder();

                foreach (char letter in messege)
                {
                    char decriptedLetter = (char)(letter - decodeNum);
                    decriptedMessege.Append(decriptedLetter);
                }
                string information = decriptedMessege.ToString();

                Match match = codeRegex.Match(information);

                if (match.Success)
                {
                    planerName = match.Groups[1].Value;
                    attackType = match.Groups[3].Value;
                }

                if (attackType == "A")
                {
                    attackPlanets.Add(planerName);
                }
                else if (attackType == "D")
                {
                    destroyedPlanets.Add(planerName);
                }
                
            }

            Console.WriteLine($"Attacked planets: {attackPlanets.Count}");
            if (attackPlanets.Count>0)
            {
                foreach (var planet in attackPlanets.OrderBy(p=>p))
                {
                    Console.WriteLine($"-> {planet}");
                }
            }

            Console.WriteLine($"Destroyed planets: {destroyedPlanets.Count}");
            if (destroyedPlanets.Count>0)
            {
                foreach (var planet in destroyedPlanets.OrderBy(p => p))
                {
                    Console.WriteLine($"-> {planet}");
                }
            }
        }
    }
}
