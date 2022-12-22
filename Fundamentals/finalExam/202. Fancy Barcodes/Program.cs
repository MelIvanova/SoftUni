using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _202._Fancy_Barcodes
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"@[#]+[A-Z][A-Za-z\d]{4,}[A-Z]@[#]+";
            Regex regex = new Regex(pattern);
            int n = int.Parse(Console.ReadLine());
            string barcode = Console.ReadLine();
            

            for (int i = 0; i < n; i++)
            {
                Match match = regex.Match(barcode);

                if (match.Success)
                {
                    string numPattern = @"\d";
                    Regex numRegex = new Regex(numPattern);
                    MatchCollection numMatch = numRegex.Matches(match.Value);

                    if (numMatch.Count>0)
                    {
                        string group = string.Empty;

                        foreach (Match num in numMatch)
                        {
                            group += num;
                        }
                        Console.WriteLine($"Product group: {group}");
                    }
                    else
                    {
                        Console.WriteLine("Product group: 00");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }

                barcode = Console.ReadLine();
            }
        }
    }
}
