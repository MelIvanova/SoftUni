using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> forceBook = new Dictionary<string, string>();
            string input = Console.ReadLine();

            while (input != "Lumpawaroo")
            {
                if (input.Contains(" | "))
                {
                    string[] joiningArguments = input.
                        Split(" | ");
                    string force = joiningArguments[0];
                    string user = joiningArguments[1];
                    if (!forceBook.ContainsKey(user))
                    {
                        forceBook.Add(user, force);
                    }
             
                }
                else if (input.Contains(" -> "))
                {
                    string[] sideChangeArgs = input.Split(" -> ");
                    string userChange = sideChangeArgs[0];
                    string toForce = sideChangeArgs[1];
                  
                    if (forceBook.ContainsKey(userChange))
                    {
                        forceBook[userChange] = toForce;
                    }
                    else
                    {
                        forceBook.Add(userChange, toForce);
                    }
                    
                    Console.WriteLine($"{userChange} joins the {toForce} side!");
                }
                input = Console.ReadLine();
            }
           

            foreach (var kvp in forceBook.GroupBy(x => x.Value)
                .OrderByDescending(x => x.Count())
                .ThenBy(c => c.Key))
            {

                Console.WriteLine($"Side: {kvp.Key}, Members: {kvp.Count()}");

                foreach (var elm in kvp.OrderBy(t => t.Key))
                {
                    Console.WriteLine($"! {elm.Key}");
                }
            }
        }
    }
}
