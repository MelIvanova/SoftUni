using System;
using System.Text.RegularExpressions;

namespace _03._SoftUni_Bar_Income
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"%([A-Z][a-z]+)%[^|$%.]*<(\w+)>[^|$%.]*\|(\d+)\|[^|$%.]*?(\d+\.?\d*)\$";
            Regex regex = new Regex(pattern);
            string input = Console.ReadLine();
            double finalSum = 0;

            while (input != "end of shift")
            {
                Match match = regex.Match(input);
                double totalPrice = 0;
                if (match.Success)
                {
                    string name = match.Groups[1].Value;
                    string product = match.Groups[2].Value;
                    int count = int.Parse(match.Groups[3].Value.ToString());
                    double price = double.Parse(match.Groups[4].Value.ToString());
                    totalPrice = count * price;
                    Console.WriteLine($"{name}: {product} - {totalPrice:f2}");
                    finalSum += totalPrice;
                }
                input = Console.ReadLine();
            }

            Console.WriteLine($"Total income: {finalSum:f2}");
        }
    }
}
