using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._SoftUni_Exam_Results
{


    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> usersPoints = new Dictionary<string, int>();

            Dictionary<string, int> languageCount = new Dictionary<string, int>();
            string input = Console.ReadLine();

            while (input != "exam finished")
            {
                string[] arguments = input.Split('-');
                string user = arguments[0];
                if (arguments.Length == 3)
                {
                    string language = arguments[1];
                    int points = int.Parse(arguments[2]);

                    if (!usersPoints.ContainsKey(user))
                    {
                        usersPoints.Add(user, points);
                    }
                    else
                    {
                        if (usersPoints[user] < points)
                        {
                            usersPoints[user] = points;
                        }
                    }
                    if (!languageCount.ContainsKey(language))
                    {
                        languageCount.Add(language, 0);
                    }
                    languageCount[language]++;
                }
                else
                {
                    usersPoints.Remove(user);
                }
                input = Console.ReadLine();
            }
            Console.WriteLine("Results:");

            foreach (var kvp in usersPoints.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{kvp.Key} | {kvp.Value}");
            }
            Console.WriteLine("Submissions:");
            foreach (var kvp in languageCount.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{kvp.Key} - {kvp.Value}");
            }
        }
    }
}
