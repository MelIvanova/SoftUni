using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _01._Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @">>([A-Za-z]+)<<(\d+\.?\d+)!(\d+)";
            Regex regex = new Regex(pattern);
            string input = Console.ReadLine();
            double totalPrice = 0.0;
            StringBuilder print = new StringBuilder();
            print.AppendLine("Bought furniture:");

            while (input != "Purchase")
            {
                if (regex.IsMatch(input))
                {
                    var match = regex.Match(input);
                    print.AppendLine(match.Groups[1].ToString());
                    totalPrice += double.Parse(match.Groups[2].ToString()) *
                        double.Parse(match.Groups[3].ToString());

                }
                input = Console.ReadLine();
            }

            print.AppendLine($"Total money spend: {totalPrice:F2}");

            Console.WriteLine(print.ToString());
        }
    }
}
