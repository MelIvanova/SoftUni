using System;

namespace PrintDeck
{
    class Program
    {
        static void Main(string[] args)
        {
            string card = Console.ReadLine();
            int deckNum = 0;

            if (card == "A" || card == "J" || card == "Q" || card == "K")
            {
                switch (card)
                {
                    case "A":
                        deckNum = 14;
                        break;
                    case "K":
                        deckNum = 13;
                        break;
                    case "Q":
                        deckNum = 12;
                        break;
                    case "J":
                        deckNum = 11;
                        break;
                }
            }
            else
            {
                deckNum = int.Parse(card);
            }

            for (int i = 2; i <= deckNum; i++)
            {
                if (i<11)
                {
                    Console.WriteLine($"{i} of spades, {i} of clubs, {i} of hearts, {i} of diamonds");
                }
                else
                {
                    switch (card)
                    {
                        case "A":
                            Console.WriteLine($"J of spades, J of clubs, J of hearts, J of diamonds");
                            Console.WriteLine($"Q of spades, Q of clubs, Q of hearts, Q of diamonds");
                            Console.WriteLine($"K of spades, K of clubs, K of hearts, K of diamonds");
                            Console.WriteLine($"A of spades, A of clubs, A of hearts, A of diamonds");
                            break;
                        case "K":
                            Console.WriteLine($"J of spades, J of clubs, J of hearts, J of diamonds");
                            Console.WriteLine($"Q of spades, Q of clubs, Q of hearts, Q of diamonds");
                            Console.WriteLine($"K of spades, K of clubs, K of hearts, K of diamonds");
                            break;
                        case "Q":
                            Console.WriteLine($"J of spades, J of clubs, J of hearts, J of diamonds");
                            Console.WriteLine($"Q of spades, Q of clubs, Q of hearts, Q of diamonds");
                            break;
                        case "J":
                            Console.WriteLine($"J of spades, J of clubs, J of hearts, J of diamonds");
                            break;
                    }
                    break;
                }
            }
        }
    }
}
