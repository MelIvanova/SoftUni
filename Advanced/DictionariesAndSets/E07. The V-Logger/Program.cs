using System;
using System.Collections.Generic;
using System.Linq;

namespace E07._The_V_Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, SortedSet<string>[]> vlogersData = new Dictionary<string, SortedSet<string>[]>();
            string[] information = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            while (information[0] != "Statistics")
            {
                string command = information[1];

                if (command == "joined")
                {
                    string vloger = information[0];
                    if (!vlogersData.ContainsKey(vloger))
                    {
                        vlogersData[vloger] = new[] { new SortedSet<string>(), new SortedSet<string>() };
                    }
                }
                else if (command== "followed")
                {
                    string follower = information[0];
                    string followed = information[2];

                    if (CanFollow(followed, follower, vlogersData))
                    {
                        vlogersData[followed][0].Add(follower);
                        vlogersData[follower][1].Add(followed);
                    }
                }

                information = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }

            Console.WriteLine($"The V-Logger has a total of {vlogersData.Keys.Count} vloggers in its logs.");

            int place = 1;

            foreach (var person in vlogersData.OrderByDescending(f => f.Value[0].Count).ThenBy(f => f.Value[1].Count))
            {
                Console.WriteLine($"{place}. {person.Key} :" +
                    $" {person.Value[0].Count} followers, {person.Value[1].Count} following");
                if (place==1 && person.Value[0].Count>0)
                {
                    foreach (var name in person.Value[0])
                    {
                        Console.WriteLine($"*  {name}");
                    }  
                }
                place++;
            }
        }


        private static bool CanFollow(string followed, string follower, Dictionary<string, SortedSet<string>[]> vlogersData)
        {
            return follower != followed && vlogersData.ContainsKey(follower) && vlogersData.ContainsKey(followed);
        }
    }
}
