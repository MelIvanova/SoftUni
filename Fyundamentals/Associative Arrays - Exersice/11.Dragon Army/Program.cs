using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.Dragon_Army
{
    class Program
    {
        static void Main(string[] args)
        {
            int income = int.Parse(Console.ReadLine());
            Dictionary<string, SortedDictionary<string, int[]>> dragonArmy =
                new Dictionary<string, SortedDictionary<string, int []>>();
            for (int i = 0; i < income; i++)
            {
                string[] flog = Console.ReadLine().Split();
                string type = flog[0];
                string name = flog[1];
                int damage = 0;
                int health = 0;
                int armor = 0;
                if (flog[2] == "null")
                {
                    damage = 45;
                }
                else
                {
                    damage = int.Parse(flog[2]);
                }
                if (flog[3] == "null")
                {
                    health = 250;
                }
                else
                {
                    health = int.Parse(flog[3]);
                }
                if (flog[4] == "null")
                {
                    armor = 10;
                }
                else
                {
                    armor = int.Parse(flog[4]);
                }
                if (dragonArmy.ContainsKey(type))
                {
                    dragonArmy[type].Add(name, new int[3]);
                    dragonArmy[type][name][0] = (damage);
                    dragonArmy[type][name][1] = (health);
                    dragonArmy[type][name][2] = (armor);
                    continue;
                }
                else
                {
                    dragonArmy.Add(type, new SortedDictionary<string, int[]>());
                }

                if (dragonArmy.ContainsKey(type) && !dragonArmy[type].ContainsKey(name))
                {
                    dragonArmy[type].Add(name, new int[3]);
                    dragonArmy[type][name][0]=(damage);
                    dragonArmy[type][name][1]=(health);
                    dragonArmy[type][name][2]=(armor);
                }
                else
                {
                    dragonArmy[type][name][0]=(damage);
                    dragonArmy[type][name][1]=(health);
                    dragonArmy[type][name][2]=(armor);
                }
            }
            foreach (var t in dragonArmy)
            {
                var damage = t.Value.Select(d => d.Value[0]).Average();
                var healt = t.Value.Select(d => d.Value[1]).Average();
                var armor = t.Value.Select(d => d.Value[2]).Average();
                Console.WriteLine($"{t.Key}::({damage:F2}/{healt:F2}/{armor:F2})");

                foreach (var d in t.Value)
                {
                    Console.WriteLine($"-{d.Key} -> damage: {d.Value[0]}, health: {d.Value[1]}, armor: {d.Value[2]}");
                }
            }

        }

        
    }


}