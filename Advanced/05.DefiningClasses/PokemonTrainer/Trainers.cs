using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonTrainer
{
    public class Trainers
    {
        public Trainers(string name, int badges, List<Pokemon> pokemons)
        {
            Name = name;
            NumberOfBadges = badges;
            CollectionOfPokemons = pokemons;
        }

        public string  Name { get; set; }

        public int NumberOfBadges { get; set; }

        public List<Pokemon> CollectionOfPokemons { get; set; }
    }
}
