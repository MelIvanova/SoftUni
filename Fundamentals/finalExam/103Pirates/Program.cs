using System;
using System.Collections.Generic;
using System.Linq;

namespace _103Pirates
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<int>> townInformation = new Dictionary<string, List<int>>();
            string input = Console.ReadLine();

            while (input != "Sail")
            {
                string[] arguments = input.Split("||");
                string town = arguments[0];
                int population = int.Parse(arguments[1]);
                int gold = int.Parse(arguments[2]);

                if (townInformation.ContainsKey(town))
                {
                    townInformation[town][0] += population;
                    townInformation[town][1] += gold;
                }
                else
                {
                    townInformation.Add(town, new List<int> { population, gold });
                }

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            while (input != "End")
            {
                string[] commandArg = input.Split("=>");
                string command = commandArg[0];
                string town = commandArg[1];

                if (command == "Plunder")
                {
                    int people = int.Parse(commandArg[2]);
                    int gold = int.Parse(commandArg[3]);

                    Console.WriteLine($"{town} plundered! {gold} gold stolen, {people} citizens killed.");

                    townInformation[town][0] -= people;
                    townInformation[town][1] -= gold;

                    if (townInformation[town][0] == 0 || townInformation[town][1] == 0)
                    {
                        townInformation.Remove(town);
                        Console.WriteLine($"{town} has been wiped off the map!");
                    }
                }
                else if (command == "Prosper")
                {
                    int gold = int.Parse(commandArg[2]);

                    if (gold<0)
                    {
                        Console.WriteLine("Gold added cannot be a negative number!");
                        input = Console.ReadLine();
                        continue;
                    }

                    townInformation[town][1] += gold;
                    Console.WriteLine($"{gold} gold added to the city treasury." +
                        $" {town} now has {townInformation[town][1]} gold.");
                }

                input = Console.ReadLine();
            }

            if (townInformation.Count>0)
            {
                Console.WriteLine($"Ahoy, Captain! There are {townInformation.Count} wealthy settlements to go to:");

                foreach (var town in townInformation.OrderByDescending(x=>x.Value[1]).ThenBy(x=>x.Key))
                {
                    Console.WriteLine($"{town.Key} -> Population: {town.Value[0]} citizens, Gold: {town.Value[1]} kg");
                }
            }
            else
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }
        }
    }
}
