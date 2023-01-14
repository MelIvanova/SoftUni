using System;
using System.Collections.Generic;
using System.Linq;

namespace _701.Cooking
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> liquits = new Queue<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
            Stack<int> ingredients = new Stack<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
            Dictionary<string, int> baked = new Dictionary<string, int>
            {
                {"Bread", 0 },
                {"Cake", 0 },
                {"Fruit Pie", 0 },
                {"Pastry", 0 },
            };

            while (liquits.Any() && ingredients.Any())
            {
                switch ((liquits.Peek() + ingredients.Peek()))
                {
                    case 25:
                        baked["Bread"]++;
                        ingredients.Pop();
                        liquits.Dequeue();
                        break;
                    case 50:
                        baked["Cake"]++;
                        ingredients.Pop();
                        liquits.Dequeue();
                        break;
                    case 75:
                        baked["Pastry"]++;
                        ingredients.Pop();
                        liquits.Dequeue();
                        break;
                    case 100:
                        baked["Fruit Pie"]++;
                        ingredients.Pop();
                        liquits.Dequeue();
                        break;
                    default:
                        liquits.Dequeue();
                        int addIngredients = ingredients.Pop() + 3;
                        ingredients.Push(addIngredients);
                        break;
                }
            }

            if (baked["Bread"] > 0 && baked["Cake"] > 0 && baked["Pastry"] > 0 && baked["Fruit Pie"] > 0)
            {
                Console.WriteLine("Wohoo! You succeeded in cooking all the food!");
            }
            else
            {
                Console.WriteLine("Ugh, what a pity! You didn't have enough materials to cook everything.");
            }

            if (liquits.Count>0)
            {
                Console.Write("Liquids left: ");
                Console.Write(String.Join(", ",liquits.ToArray()));
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Liquids left: none");
            }

            if (ingredients.Count>0)
            {
                Console.Write("Ingredients left: ");
                Console.Write(String.Join(", ", ingredients.ToArray()));
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Ingredients left: none");
            }

            foreach (var bakeGoot in baked)
            {
                Console.WriteLine($"{bakeGoot.Key}: {bakeGoot.Value}");
            }
        }
    }
}
