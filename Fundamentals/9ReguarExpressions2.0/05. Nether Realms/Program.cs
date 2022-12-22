using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _05._Nether_Realms
{
    class Demon
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public double Damage { get; set; }

        public override string ToString()
        {
            return $"{Name} - {Health} health, {Damage:f2} damage";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
            string pattern = @"[-+]?[\d]+\.?[\d]*";

            List<Demon> allDemons = new List<Demon>();
            Regex numRegex = new Regex(pattern);

            string[] demons = Console.ReadLine().Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var demon in demons)
            {
                string filter = "1234567890+-./*";

                int health = demon.Where(d => !filter.Contains(d)).Sum(c => c);
                double damage = CalculateDamage(numRegex, demon);
                allDemons.Add(new Demon { Name = demon, Health = health, Damage = damage });

            }

            foreach (var demon in allDemons.OrderBy(x=>x.Name))
            {
                Console.WriteLine(demon);
            }
            
        }

        private static double CalculateDamage(Regex numRegex, string demon)
        {
            MatchCollection numMatch = numRegex.Matches(demon);
            double damage = 0;

            foreach (Match match in numMatch)
            {
                damage += double.Parse(match.Value);
            }
            foreach (var ch in demon)
            {
                if (ch == '*')
                {
                    damage *= 2.0;
                }
                else if (ch == '/')
                {
                    damage /= 2.0;
                }
            }
            return damage;
        }
    }
}
