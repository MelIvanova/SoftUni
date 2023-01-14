using System;
using System.Collections.Generic;
using System.Linq;

namespace A04._Cities_by_Continent_and_Country
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, List<string>>> globe =
                new Dictionary<string, Dictionary<string, List<string>>>();      

            for (int i = 0; i < n; i++)
            {
                string[] information = Console.ReadLine().Split();
                string continent = information[0];
                string counrey = information[1];
                string city = information[2];

                if (!globe.ContainsKey(continent))
                {
                    globe[continent] = new Dictionary<string, List<string>>();
                }

                if (!globe[continent].ContainsKey(counrey))
                {
                    globe[continent][counrey] = new List<string>();
                }

                globe[continent][counrey].Add(city);
            }

            foreach (var continent in globe)
            {
                Console.WriteLine($"{continent.Key}:");

                foreach (var countrey in continent.Value)
                {
                    Console.Write($"  {countrey.Key} -> ");
                    Console.WriteLine(String.Join(", ",countrey.Value));
                }
            }

        }
    }
}
