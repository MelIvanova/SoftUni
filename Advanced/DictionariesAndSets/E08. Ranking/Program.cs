using System;
using System.Collections.Generic;
using System.Linq;

namespace E08._Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> contestsPassword = new Dictionary<string, string>();
            string contestInfo = Console.ReadLine();

            while (contestInfo != "end of contests")
            {
                string[] data = contestInfo.Split(':');
                string contest = data[0];
                string password = data[1];

                contestsPassword[contest] = password;

                contestInfo = Console.ReadLine();
            }

            SortedDictionary<string, Dictionary<string, int>> usersResult = new 
                SortedDictionary<string, Dictionary<string, int>>();

            contestInfo = Console.ReadLine();

            while (contestInfo != "end of submissions")
            {
                string[] userData = contestInfo.Split("=>");
                string contest = userData[0];
                string password = userData[1];
                string user = userData[2];
                int points = int.Parse(userData[3]);

                if (contestsPassword.ContainsKey(contest) && contestsPassword[contest]==password)
                {
                    if (!usersResult.ContainsKey(user))
                    {
                        usersResult[user] = new Dictionary<string, int>();
                    }
                    
                    if (!usersResult[user].ContainsKey(contest))
                    {
                        usersResult[user][contest] = points;
                    }
                    else
                    {
                        if (usersResult[user][contest] < points)
                        {
                            usersResult[user][contest] = points;
                        }
                    }
                }

                contestInfo = Console.ReadLine();
            }

            string top = string.Empty;
            int totals = 0;

            foreach (var user in usersResult)
            {
                int sum = 0;

                foreach (var item in user.Value)
                {
                    sum += item.Value;
                }

                if (sum > totals)
                {
                    totals = sum;
                    top = user.Key;
                }
            }

            Console.WriteLine($"Best candidate is {top} with total {totals} points.");
            Console.WriteLine("Ranking:");

            foreach (var user in usersResult)
            {
                Console.WriteLine(user.Key);

                foreach (var item in user.Value.OrderByDescending(p=>p.Value))
                {
                    Console.WriteLine($"#  {item.Key} -> {item.Value}");
                }
            }
        }
    }
}
