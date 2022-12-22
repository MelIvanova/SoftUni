using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _502.AdAstra
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(#|\|)([A-Za-z\s]+)\1(([012][0-9]|[3][01])\/([0][1-9]|[1][0-2])\/([0-9]{2}))\1([0-9]{1,5})\1";
            string text = Console.ReadLine();
            Regex regex = new Regex(pattern);
            int daylyCallory = 2000;
            MatchCollection matches = regex.Matches(text);
            List<int> callories = new List<int>();

            foreach ( Match match in matches)
            {
                int call = int.Parse(match.Groups[7].Value);
                callories.Add(call);
            }
            int allCallories = callories.Sum();
            int days = allCallories / daylyCallory;
            Console.WriteLine($"You have food to last you for: {days} days!");

            foreach (Match match in matches)
            {
                Console.WriteLine($"Item: {match.Groups[2].Value}, Best before: {match.Groups[3].Value}, Nutrition: {match.Groups[7].Value}");
            }
        }
    }
}
