using System;
using System.Collections.Generic;
using System.Linq;

namespace _403PlantDiscovery
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> plantRarity = new Dictionary<string, List<double>>();
            Dictionary<string, List<double>> plantRating = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split("<->");
                string plant = input[0];
                double rarity = double.Parse(input[1]);
                if (plantRarity.ContainsKey(plant))
                {
                    plantRarity[plant][0] = rarity;
                }
                else
                {
                    plantRarity[plant] = new List<double> { rarity };
                    plantRating[plant] = new List<double>();

                }
            }

            string income = Console.ReadLine();

            while (income != "Exhibition")
            {
                string[] arguments = income.Split(new[] {':',' ','-' },StringSplitOptions.RemoveEmptyEntries);
                string command = arguments[0];
                string plant = arguments[1];
                if (command == "Rate")
                {
                    double raiting = double.Parse(arguments[2]);

                    if (plantRating.ContainsKey(plant))
                    {
                        plantRating[plant].Add(raiting);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else if (command == "Update")
                {
                    double rarity = double.Parse(arguments[2]);
                    if (plantRarity.ContainsKey(plant))
                    {
                        plantRarity[plant][0] = rarity;
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else if (command == "Reset")
                {
                    if (plantRating.ContainsKey(plant))
                    {
                        plantRating[plant].Clear();
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else
                {
                    Console.WriteLine("error");
                }
                
                income = Console.ReadLine();
            }
            Console.WriteLine("Plants for the exhibition:");

            Dictionary<string, double> averageRating = new Dictionary<string, double>();

            foreach (var plant in plantRating)
            {
                if (plant.Value.Count > 0)
                {
                    averageRating.Add(plant.Key, plant.Value.Average());
                }
                else
                {
                    averageRating.Add(plant.Key, 0);
                }
            }
            
            foreach (var plant in plantRarity)
            {
                if (averageRating.ContainsKey(plant.Key))
                {
                    plantRarity[plant.Key].Add(averageRating[plant.Key]);
                }
            }

            foreach (var plant in plantRarity.OrderByDescending(p => p.Value[0]).ThenByDescending(p => p.Value[1]))
            {
                Console.WriteLine($"- {plant.Key}; Rarity: {plant.Value[0]}; Rating: {plant.Value[1]:f2}");
            }
        }
    }
}
