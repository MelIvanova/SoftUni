using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Match_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string numbers = Console.ReadLine();
            string pattern = @"\+359( |-)2(\1)\d{3}(\1)\d{4}\b";

            MatchCollection matched = Regex.Matches(numbers,pattern);

            var match = matched.Cast<Match>().Select(a => a.Value.Trim()).ToArray();

            Console.WriteLine(String.Join(", ",match));
        }
    }
}
