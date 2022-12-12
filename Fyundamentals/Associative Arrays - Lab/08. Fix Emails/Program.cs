using System;
using System.Collections.Generic;

namespace _08._Fix_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> emailLog = new Dictionary<string, string>();
            string name = "";
            string email = "";
            while (name!="stop")
            {
                name = Console.ReadLine();
                if (name != "stop")
                {
                    email = Console.ReadLine();
                }
                else
                {
                    continue;
                }
                if (! emailLog.ContainsKey(name))
                {
                    if (email[email.Length-1] == 's' || email[email.Length - 1] == 'k')
                    {
                        continue;
                    }
                    else
                    {
                        emailLog.Add(name, email);
                    }
                }
                
                
            }
            foreach (var kvp in emailLog)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
