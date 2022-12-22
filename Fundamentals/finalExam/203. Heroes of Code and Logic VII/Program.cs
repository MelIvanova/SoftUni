using System;
using System.Collections.Generic;
using System.Linq;

namespace _203._Heroes_of_Code_and_Logic_VII
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string heroInfo = Console.ReadLine();
            Dictionary<string, List<int>> heroesHpMp = new Dictionary<string, List<int>>();
            int maxHp = 100;
            int maxMp = 200;

            for (int i = 1; i <= n; i++)
            {
                string[] heroes = heroInfo.Split(" ");
                string hero = heroes[0];
                int hp = int.Parse(heroes[1]);
                int mp = int.Parse(heroes[2]);
                heroesHpMp.Add(hero, new List<int> { hp, mp });
                heroInfo = Console.ReadLine();
            }

            while (heroInfo != "End")
            {
                string[] arguments = heroInfo.Split(" - ");
                string command = arguments[0];
                string hero = arguments[1];
                switch (command)
                {
                    case "CastSpell":
                        int needMp = int.Parse(arguments[2]);
                        string spell = arguments[3];
                        if (heroesHpMp[hero][1] >= needMp)
                        {
                            heroesHpMp[hero][1] -= needMp;
                            Console.WriteLine($"{hero} has successfully cast {spell} " +
                                $"and now has {heroesHpMp[hero][1]} MP!");
                        }
                        else
                        {
                            Console.WriteLine($"{hero} does not have enough MP to cast {spell}!");
                        }
                        break;
                    case "TakeDamage":
                        int damage = int.Parse(arguments[2]);
                        string attacker = arguments[3];
                        heroesHpMp[hero][0] -= damage;
                        if (heroesHpMp[hero][0] > 0)
                        {
                            Console.WriteLine($"{hero} was hit for {damage} HP by {attacker} " +
                                $"and now has {heroesHpMp[hero][0]} HP left!");
                        }
                        else
                        {
                            heroesHpMp.Remove(hero);
                            Console.WriteLine($"{hero} has been killed by {attacker}!");
                        }
                        break;
                    case "Recharge":
                        int amountMp = int.Parse(arguments[2]);
                        if (heroesHpMp[hero][1]+amountMp>maxMp)
                        {
                            int recoverd = maxMp - heroesHpMp[hero][1];
                            heroesHpMp[hero][1] = maxMp;
                            Console.WriteLine($"{hero} recharged for {recoverd} MP!");
                        }
                        else
                        {
                            heroesHpMp[hero][1] += amountMp;
                            Console.WriteLine($"{hero} recharged for {amountMp} MP!");
                        }
                        break;
                    case "Heal":
                        int amountHp = int.Parse(arguments[2]);
                        if (heroesHpMp[hero][0] + amountHp > maxHp)
                        {
                            int recoverd = maxHp - heroesHpMp[hero][0];
                            heroesHpMp[hero][0] = maxHp;
                            Console.WriteLine($"{hero} healed for {recoverd} HP!");
                        }
                        else
                        {
                            heroesHpMp[hero][0] += amountHp;
                            Console.WriteLine($"{hero} healed for {amountHp} HP!");
                        }
                        break;
                }

                heroInfo = Console.ReadLine();
            }

            foreach (var hero in heroesHpMp.OrderByDescending(h => h.Value[0]).ThenBy(h => h.Key))
            {
                Console.WriteLine($"{hero.Key}");
                Console.WriteLine($"  HP: {hero.Value[0]}");
                Console.WriteLine($"  MP: {hero.Value[1]}");
            }

        }
    }
}
