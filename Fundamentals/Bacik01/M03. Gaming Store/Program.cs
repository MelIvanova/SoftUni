using System;

namespace M03._Gaming_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            double buget = double.Parse(Console.ReadLine());
            string game = Console.ReadLine();
            double priceGame = 0;
            double spend = 0;

            while (game != "Game Time")
            {
                switch (game)
                {
                    case "OutFall 4":
                        priceGame = 39.99;
                        if (buget < priceGame)
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        else
                        {
                            Console.WriteLine($"Bought {game}");
                            buget -= priceGame;
                            spend += priceGame;
                        }
                        break;
                    case "CS: OG":
                        priceGame = 15.99;
                        if (buget < priceGame)
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        else
                        {
                            Console.WriteLine($"Bought {game}");
                            buget -= priceGame;
                            spend += priceGame;
                        }
                        break;
                    case "Zplinter Zell":
                        priceGame = 19.99;
                        if (buget < priceGame)
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        else
                        {
                            Console.WriteLine($"Bought {game}");
                            buget -= priceGame;
                            spend += priceGame;
                        }
                        break;
                    case "Honored 2":
                        priceGame = 59.99;
                        if (buget < priceGame)
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        else
                        {
                            Console.WriteLine($"Bought {game}");
                            buget -= priceGame;
                            spend += priceGame;
                        }
                        break;
                    case "RoverWatch":
                        priceGame = 29.99;
                        if (buget < priceGame)
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        else
                        {
                            Console.WriteLine($"Bought {game}");
                            buget -= priceGame;
                            spend += priceGame;
                        }
                        break;
                    case "RoverWatch Origins Edition":
                        priceGame = 39.99;
                        if (buget < priceGame)
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        else
                        {
                            Console.WriteLine($"Bought {game}");
                            buget -= priceGame;
                            spend += priceGame;
                        }
                        break;
                    default:
                        Console.WriteLine("Not Found");
                        break;
                }

                if (buget == 0)
                {
                    Console.WriteLine("Out of money!");
                    break;
                }

                game = Console.ReadLine();
            }

            if (buget != 0)
            {
                Console.WriteLine($"Total spent: ${spend:F2}. Remaining: ${buget:F2}");
            }
            
        }
    }
}
