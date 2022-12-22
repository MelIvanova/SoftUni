using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _02._Race
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> participants = new Dictionary<string, int>();
            string[] names = Console.ReadLine().Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
            string text = Console.ReadLine();
            string namePattern = @"([A-Za-z]+)";
            string numbersPattern = @"(\d+)";
            Regex nameFound = new Regex(namePattern);
            Regex numberFound = new Regex(numbersPattern);

            for (int i = 0; i < names.Length; i++)
            {
                participants.Add(names[i], 0);
            }

            while (text != "end of race")
            {
                MatchCollection matchName = nameFound.Matches(text);
                string name = string.Join("", matchName);
                if (participants.ContainsKey(name))
                {
                    MatchCollection matchNumbers = numberFound.Matches(text);
                    string numbers = string.Join("", matchNumbers);
                    int distance = 0;
                    foreach (var num in numbers)
                    {
                        int current = int.Parse(num.ToString());
                        distance += current;
                    }

                    participants[name] += distance;

                }
                text = Console.ReadLine();
            }
            participants = participants.OrderByDescending(d => d.Value).Take(3)
                .ToDictionary(k => k.Key, v => v.Value);
            List<string> person = new List<string>();

            foreach (var item in participants)
            {
                person.Add(item.Key);
            }
            Console.WriteLine($"1st place: {person[0]}");
            Console.WriteLine($"2nd place: {person[1]}");
            Console.WriteLine($"3rd place: {person[2]}");
        }
    }
}
