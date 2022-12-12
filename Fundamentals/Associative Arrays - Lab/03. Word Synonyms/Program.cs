using System;
using System.Collections.Generic;

namespace _03._Word_Synonyms
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> synonym = new Dictionary<string, List<string>>();
            for (int i = 0; i < count; i++)
            {
                string key = Console.ReadLine();
                string value = Console.ReadLine();
                if (!synonym.ContainsKey(key))
                {
                    synonym[key] = new List<string>();
                }
                synonym[key].Add(value);
            }
            foreach (var item in synonym)
            {
                Console.WriteLine(item.Key + " - " + String.Join( ", ", item.Value));
            }

        }

    }
}
