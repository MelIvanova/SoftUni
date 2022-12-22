using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._Pokemon_Don_t_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> pokemons = Console.ReadLine()
                                               .Split()
                                               .Select(int.Parse)
                                               .ToList();

            List<int> result = new List<int>();
            int element = 0;

            while (pokemons.Count > 0)
            {
                int index = int.Parse(Console.ReadLine());
                
                if (index < 0)
                {
                    index = 0;
                    element = pokemons[index];
                    pokemons[0] = pokemons[pokemons.Count - 1];

                }
                else if (index > pokemons.Count - 1)
                {
                    index = pokemons.Count - 1;
                    element = pokemons[index];
                    pokemons[pokemons.Count - 1] = pokemons[0];
                }
                else
                {
                    element = pokemons[index];
                    pokemons.RemoveAt(index);
                }

                for (int i = 0; i < pokemons.Count; i++)
                {

                    if (pokemons[i] <= element)
                    {
                        pokemons[i] += element;
                    }
                    else
                    {
                        pokemons[i] -= element;
                    }
                }

                result.Add(element);
                element = 0;

            }

            Console.WriteLine(result.Sum());
        }
    }
}
