using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _601Santa_sSecretHelper
{
    class Program
    {
        static void Main(string[] args)
        {
            int changeKey = int.Parse(Console.ReadLine());
            string message = Console.ReadLine();
            List<string> messages = new List<string>();
            string decript = string.Empty;

            while (message!= "end")
            {
                for (int i = 0; i < message.Length; i++)
                {
                    char shift = message[i];
                    shift -= (char)changeKey;
                    decript += shift;
                }
                messages.Add(decript);
                message = Console.ReadLine();
                decript = string.Empty;
            }
            string pattern = @"@([A-Za-z]+)[^@\-!:>]*!([GN])!";
            Regex nameRegex = new Regex(pattern);
            List<string> names = new List<string>();
            List<string> goodOrNot = new List<string>();

            foreach (var text in messages)
            {
                Match matchName = nameRegex.Match(text);
                if (matchName.Success)
                {
                    names.Add(matchName.Groups[1].Value);
                    goodOrNot.Add(matchName.Groups[2].Value);
                }
            }

            for (int i = 0; i < names.Count; i++)
            {
                if (goodOrNot[i]=="G")
                {
                    Console.WriteLine(names[i]);
                }
            }

        }
    }
}
