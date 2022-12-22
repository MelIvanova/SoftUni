using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _04._Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @">>(?<name>\w+)<<(?<price>\d+\.?\d+)!(?<quantity>\d+)\b";
            string result = "";
            while (input!="Purchase")
            {
                result += input;
                input = Console.ReadLine();
            }
            MatchCollection furniture = Regex.Matches(result, pattern);
            Console.WriteLine("Bought furniture:");
            var sum = 0.0;
            foreach (Match item in furniture)
            {
                var name = item.Groups["name"].Value;
                var price = item.Groups["price"].Value;
                var quantity = item.Groups["quantity"].Value;
                sum += double.Parse(price) * int.Parse(quantity);
                Console.WriteLine($"{name}");
            }
            Console.WriteLine($"Total money spend: {sum:F2}");
        }
    }
}
