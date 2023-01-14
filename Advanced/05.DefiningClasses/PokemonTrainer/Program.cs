using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonTrainer
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Trainers> compadetors = new List<Trainers>();

            string data = Console.ReadLine();

            while (data != "Tournament")
            {
                string[] pockemonData = data.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string trainorName = pockemonData[0];
                string pokemonName = pockemonData[1];
                string element = pockemonData[2];
                int health = int.Parse(pockemonData[3]);

                if (compadetors.Count == 0)
                {
                    compadetors.Add(new Trainers(trainorName, 0, new List<Pokemon>
                        { new Pokemon(pokemonName, element,health) }));
                }
                else
                {
                    for (int i = 0; i < compadetors.Count; i++)
                    {
                        if (compadetors[i].Name == trainorName)
                        {
                            compadetors[i].CollectionOfPokemons.Add(new Pokemon
                                (pokemonName, element, health));
                            break;
                        }

                        if (i == compadetors.Count-1)
                        {
                            compadetors.Add(new Trainers(trainorName, 0, new List<Pokemon>
                             { new Pokemon(pokemonName, element,health) }));
                            break;
                        }
                    }
                }

                data = Console.ReadLine();
            }

            string command = Console.ReadLine();
            while (command != "End")
            {
                foreach (var trainer in compadetors)
                {
                    bool haveNon = true;

                    if (trainer.CollectionOfPokemons.Count > 0)
                    {
                        foreach (var pokemon in trainer.CollectionOfPokemons)
                        {
                            if (pokemon.Element == command)
                            {
                                trainer.NumberOfBadges++;
                                haveNon = false;
                                break;
                            }
                        }

                        if (haveNon)
                        {
                            for(int i =0; i< trainer.CollectionOfPokemons.Count; i++)
                            {
                                trainer.CollectionOfPokemons[i].Health -= 10;
                                if (trainer.CollectionOfPokemons[i].Health <= 0)
                                {
                                    trainer.CollectionOfPokemons.Remove(trainer.CollectionOfPokemons[i]);
                                    i--;
                                }

                                if (trainer.CollectionOfPokemons.Count == 0)
                                {
                                    break;
                                }
                            }
                        }
                    }
                }
                command = Console.ReadLine();
            }

            foreach (var trainer in compadetors.OrderByDescending(t => t.NumberOfBadges))
            {
                Console.WriteLine($"{trainer.Name} {trainer.NumberOfBadges} " +
                    $"{trainer.CollectionOfPokemons.Count}");
            }
        }
    }
}
