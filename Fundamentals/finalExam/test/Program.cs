using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.HeroesOfCodeAndLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> infoHeroes = new Dictionary<string, Dictionary<string, int>>();
            int numOfHeroes = int.Parse(Console.ReadLine());
            for (int i = 0; i < numOfHeroes; i++)
            {
                string[] heroes = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string nameHero = heroes[0];
                int HP = int.Parse(heroes[1]);
                int MP = int.Parse(heroes[2]);
                infoHeroes.Add(nameHero, new Dictionary<string, int>()
                {
                    {"HP",HP },{"MP",MP }
                });
            }
            string[] tokens = Console.ReadLine().Split(" - ");
            while (tokens[0] != "End")
            {
                string command = tokens[0];
                string hero = tokens[1];
                if (command == "CastSpell")
                {
                    int MPneed = int.Parse(tokens[2]);
                    string spellName = tokens[3];
                    if (infoHeroes[hero]["MP"] >= MPneed)
                    {
                        infoHeroes[hero]["MP"] -= MPneed;
                        Console.WriteLine($"{hero} has successfully cast {spellName} and now has {infoHeroes[hero]["MP"]} MP!");
                    }
                    else
                    {
                        Console.WriteLine($"{hero} does not have enough MP to cast {spellName}!");
                    }
                }
                else if (command == "TakeDamage")
                {
                    int damage = int.Parse(tokens[2]);
                    string attacker = tokens[3];

                    infoHeroes[hero]["HP"] -= damage;

                    if (infoHeroes[hero]["HP"] > 0)
                    {
                        Console.WriteLine($"{hero} was hit for {damage} HP by {attacker} and now has {infoHeroes[hero]["HP"]} HP left!");
                    }
                    else
                    {
                        Console.WriteLine($"{hero} has been killed by {attacker}!");
                    }
                }
                else if (command == "Recharge")
                {
                    int amount = int.Parse(tokens[2]);
                    int newMP = infoHeroes[hero]["MP"] + amount;
                    if (newMP > 200)
                    {
                        newMP = 200;
                        Console.WriteLine($"{hero} recharged for {infoHeroes[hero]["MP"] - newMP} MP!");
                    }
                    else
                    {
                        Console.WriteLine($"{hero} recharged for {amount} MP!");
                    }
                    infoHeroes[hero]["MP"] = newMP;
                }
                else if (command == "Heal")
                {
                    int amount = int.Parse(tokens[2]);
                    int newHP = infoHeroes[hero]["HP"] + amount;
                    if (newHP > 100)
                    {
                        newHP = 100;
                        Console.WriteLine($"{hero} healed for {infoHeroes[hero]["HP"] - newHP} HP!");
                    }
                    else
                    {
                        Console.WriteLine($"{hero} healed for {amount} HP!");
                    }
                    infoHeroes[hero]["HP"] = newHP;
                }
                if (infoHeroes[hero]["HP"] <= 0)
                {
                    infoHeroes.Remove(hero);
                }
                tokens = Console.ReadLine().Split(" - ");
            }


            infoHeroes = infoHeroes.OrderByDescending(v => v.Value["HP"])
                                     .ThenBy(k => k.Key)
                                     .ToDictionary(k => k.Key, v => v.Value);
            foreach (var item in infoHeroes)
            {
                int HP = item.Value["HP"];
                int MP = item.Value["MP"];
                Console.WriteLine($"{item.Key}\n  HP: {HP}\n  MP: {MP}");
            }
        }
    }
}

