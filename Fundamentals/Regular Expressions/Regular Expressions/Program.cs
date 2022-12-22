using System;
using System.Text.RegularExpressions;

namespace Regular_Expressions
{
    class Program
    {
        static void Main(string[] args)
        {
            string  names = Console.ReadLine();
            string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";
            Regex regex = new Regex(pattern);

            MatchCollection matched = regex.Matches(names);
            foreach (Match name in matched)
            {
                Console.Write($"{name} ");
            }
        }
    }
}
