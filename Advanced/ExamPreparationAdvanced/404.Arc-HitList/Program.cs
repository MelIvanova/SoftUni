using System;
using System.Collections.Generic;
using System.Linq;

namespace _404.Arc_HitList
{
    class Program
    {
        static void Main(string[] args)
        {
            int trgetInex = int.Parse(Console.ReadLine());
            string data = Console.ReadLine();
            SortedDictionary<string, SortedDictionary<string, string>> killList =
                new SortedDictionary<string, SortedDictionary<string, string>>();

            while (data != "end transmissions")
            {
                string[] information = data.Split('=', ':', ';');
                string name = information[0];

                if (!killList.ContainsKey(name))
                {
                    killList[name] = new SortedDictionary<string, string>();
                }

                for (int i = 1; i < information.Length; i++)
                {
                    string key = information[i];
                    i++;
                    string value = information[i];
                    if (killList[name].ContainsKey(key))
                    {
                        killList[name][key] = value;
                    }
                    else
                    {
                        killList[name].Add(key, value);
                    }

                }

                data = Console.ReadLine();
            }

            string[] targetInfo = Console.ReadLine().Split();
            string targetName = targetInfo[1];
            int infoIndex = 0;

            foreach (var name in killList)
            {
                if (name.Key == targetName)
                {
                    Console.WriteLine($"Info on {targetName}:");
                    foreach (var info in name.Value)
                    {
                        Console.WriteLine($"---{info.Key}: {info.Value}");
                        infoIndex += info.Key.Length + info.Value.Length;
                    }
                }
            }

            Console.WriteLine($"Info index: {infoIndex}");
            if (infoIndex >= trgetInex)
            {
                Console.WriteLine("Proceed");
            }
            else
            {
                Console.WriteLine($"Need {trgetInex - infoIndex} more info.");
            }
        }
    }
}
