using System;
using System.Text.RegularExpressions;

namespace _06._Extract_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"[\s][A-Za-z\d]+[.\-_]?[A-Za-z\d]*@[A-Za-z\-]+(\.[A-Za-z\-]+){1,}";
            string input = Console.ReadLine();
            Regex regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(input);

            foreach (Match email in matches)
            {
                Console.WriteLine(email);
            }
        }
    }
}
