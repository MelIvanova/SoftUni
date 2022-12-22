using System;
using System.Collections.Generic;

namespace _08._Company_Users
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, List<string>> companyUsers = new SortedDictionary<string, List<string>>();
            string input = Console.ReadLine();

            while (input!= "End")
            {
                string[] arguments = input.Split(" -> ");
                string company = arguments[0];
                string employeeId = arguments[1];
                if (companyUsers.ContainsKey(company))
                {
                    if (!companyUsers[company].Contains(employeeId))
                    {
                        companyUsers[company].Add(employeeId);
                    }
                }
                else
                {
                    companyUsers.Add(company, new List<string> { employeeId });
                }
                input = Console.ReadLine();
            }

            foreach (var kvp in companyUsers)
            {
                Console.WriteLine($"{kvp.Key}");
                foreach (var ID in kvp.Value)
                {
                    Console.WriteLine($"-- {ID}");
                }
            }
        }
    }
}
