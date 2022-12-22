using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _05._Race
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> participants = Console.ReadLine().Split(", ").ToList();
            string input = Console.ReadLine();
            string patternName = @"[A-Za-z]";
            string patternNum = @"\d";
            Dictionary<string, int> race = new Dictionary<string, int>();
            while (input!="end of race")
            {
                MatchCollection compatitores = Regex.Matches(input, patternName);
                string name = "";
                foreach (Match letter in compatitores)
                {
                    name += letter;
                }
                MatchCollection results = Regex.Matches(input, patternNum);
                int result = 0;
                foreach (Match num in results)
                {
                    result += int.Parse(num.Value);
                }
                for (int i = 0; i < participants.Count; i++)
                {
                    if (participants[i]==name&& !race.ContainsKey(name))
                    {
                        race.Add(name,result);
                    }
                    else if (participants[i] == name && race.ContainsKey(name))
                    {
                        race[name] += result;
                    }

                }

                input = Console.ReadLine();
            }

            var ordered = race.OrderByDescending(x => x.Value);
            int count = 1;
            string place = "st";
            foreach (var kvp in ordered)
            {
                
                if (count<4)
                {
                    Console.WriteLine($"{count}{place} place: {kvp.Key}");
                }
                count++;
                place = "nd";
                if (count==3)
                {
                    place = "rd";
                }
            }
        }
    }
}
