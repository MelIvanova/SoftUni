using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Wizard_Poker
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> card = Console.ReadLine().Split(':').ToList();
            List<string> cardsAtDeck = new List<string>();
            string command = Console.ReadLine();

            while (command != "Ready")
            {
                string[] commands = command.Split();
                switch(commands[0])
                {
                    case "Add":
                        if (card.Contains(commands[1]))
                        {
                            cardsAtDeck.Add(commands[1]);
                        }
                        else
                        {
                            Console.WriteLine("Card not found.");
                        }
                        break;
                    case "Insert":
                        int index = int.Parse(commands[2]);
                        if (card.Contains(commands[1])&&(cardsAtDeck.Count)>index&& index>-1)
                        {
                            cardsAtDeck.Insert(index, commands[1]);
                        }
                        else
                        {
                            Console.WriteLine("Error!");
                        }
                        break;
                    case "Remove":
                        if (card.Contains(commands[1])&&cardsAtDeck.Contains(commands[1]))
                        {
                            cardsAtDeck.Remove(commands[1]);
                        }
                        else
                        {
                            Console.WriteLine("Card not found.");
                        }
                        break;
                    case "Swap":
                        int index1 = cardsAtDeck.IndexOf(commands[1]);
                        int index2 = cardsAtDeck.IndexOf(commands[2]);
     
                        string temp = cardsAtDeck[index1];
                        cardsAtDeck[index1] = cardsAtDeck[index2];
                        cardsAtDeck[index2] = temp;
                        break;
                    case "Shuffle":
                        cardsAtDeck.Reverse();
                        break;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ",cardsAtDeck));
        }
    }
}
