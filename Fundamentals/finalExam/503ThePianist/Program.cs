using System;
using System.Collections.Generic;
using System.Linq;

namespace _503ThePianist
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> pieceCompKey = new Dictionary<string, List<string>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split('|');
                string piece = input[0];
                string composer = input[1];
                string key = input[2];
                pieceCompKey[piece] = new List<string> { composer, key };
            }

            string income = Console.ReadLine();
            while (income != "Stop")
            {
                string[] arguments = income.Split('|');
                string command = arguments[0];
                string piece = arguments[1];

                switch (command)
                {
                    case "Add":
                        if (pieceCompKey.ContainsKey(piece))
                        {
                            Console.WriteLine($"{piece} is already in the collection!");
                        }
                        else
                        {
                            string composer = arguments[2];
                            string key = arguments[3];
                            pieceCompKey[piece] = new List<string> { composer, key };
                            Console.WriteLine($"{piece} by {composer} in {key} added to the collection!");
                        }
                        break;
                    case "Remove":
                        if (pieceCompKey.ContainsKey(piece))
                        {
                            pieceCompKey.Remove(piece);
                            Console.WriteLine($"Successfully removed {piece}!");
                        }
                        else
                        {
                            Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                        }
                        break;
                    case "ChangeKey":
                        if (pieceCompKey.ContainsKey(piece))
                        {
                            string newKey = arguments[2];
                            pieceCompKey[piece][1]=newKey;
                            Console.WriteLine($"Changed the key of {piece} to {newKey}!");
                        }
                        else
                        {
                            Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                        }
                        break;
                }
                income = Console.ReadLine();
            }

            foreach (var piece in pieceCompKey.OrderBy(p=>p.Key).ThenBy(p=>p.Value[0]))
            {
                Console.WriteLine($"{piece.Key} -> Composer: {piece.Value[0]}, Key: {piece.Value[1]}");
            }
        }
    }
}
