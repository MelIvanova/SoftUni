using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._Hands_of_Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] name = input.Split(": ");
            List<string> heand = name[1].Split(", ").ToList();
            Dictionary<string, List<string>> cards = new Dictionary<string, List<string>>();
            Dictionary<string, int> value = new Dictionary<string, int>();

            while (name[0]!="JOKER")
            {
                if (! cards.ContainsKey(name[0]))
                {
                    cards.Add(name[0], new List<string>());
                }
                
                    cards[name[0]].AddRange(heand.Distinct());
                
                
                input = Console.ReadLine();
                name = input.Split(": ");
                if (name.Length>1)
                {
                    heand = name[1].Split(", ").ToList();
                }
                
            }

            for (int i = 2; i <= 9; i++)
            {
                value.Add(i.ToString(), i);
            }
            value.Add("1", 10);
            value.Add("J", 11); 
            value.Add("Q", 12);
            value.Add("K", 13); 
            value.Add("A", 14); 
            value.Add("S", 4); 
            value.Add("H", 3); 
            value.Add("D", 2); 
            value.Add("C", 1);
            
            foreach (var kvp in cards)
            {
                List<string> holds = kvp.Value.ToList();
                int sum = 0;

                for (int i = 0; i < holds.Count; i++)
                {
                    string temp = holds[i];
                    string cardPowers = temp[0].ToString();
                    string cardDye = temp[temp.Length - 1].ToString();

                    int cardPow = value[cardPowers];
                    int cardSuit = value[cardDye];

                    sum += cardPow * cardSuit;
                }

                Console.WriteLine($"{kvp.Key}: {sum}");
            }
        }
    }
}