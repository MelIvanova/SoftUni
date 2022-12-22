using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _402DestinationMapper
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(=|\/)[A-Z][A-Za-z]{2,}\1";
            string text = Console.ReadLine();
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(text);
            List<string> destinations = new List<string>();
            int points = 0;
            foreach (Match travelPoint in matches)
            {
                string point = travelPoint.Value.Substring(1, travelPoint.Length - 2);
                destinations.Add(point);
                points += point.Length;
            }

            Console.WriteLine($"Destinations: {string.Join(", ", destinations)}");
            Console.WriteLine($"Travel Points: {points}");
        }
    }
}
