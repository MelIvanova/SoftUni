using System;
using System.Linq;

namespace _402._MuOnline
{
    class Program
    {
        static void Main(string[] args)
        {
            int healt = 100;
            int bitcoins = 0;
            string[] dungeonsRooms = Console.ReadLine().Split("|").ToArray();
            int count = 0;
            bool isHealthy = true;

            for (int i = 0; i < dungeonsRooms.Length && isHealthy; i++)
            {
                string[] arguments = dungeonsRooms[i].Split();
                string command = arguments[0];
                int number = int.Parse(arguments[1]);
                count++;
                switch (command)
                {
                    case "potion":
                        healt += number;
                        
                        if (healt>100)
                        {
                            int diff = 100 - (healt - number);
                            Console.WriteLine($"You healed for {diff} hp.");
                            healt = 100;
                        }
                        else
                        {
                            Console.WriteLine($"You healed for {number} hp.");
                        }
                        Console.WriteLine($"Current health: {healt} hp.");
                        break;
                    case "chest":
                        bitcoins += number;
                        Console.WriteLine($"You found {number} bitcoins.");
                        break;
                    default:
                        if (number<healt)
                        {
                            healt -= number;
                            Console.WriteLine($"You slayed {command}.");
                        }
                        else
                        {
                            Console.WriteLine($"You died! Killed by {command}.");
                            Console.WriteLine($"Best room: {count}");
                            isHealthy = false;
                        }
                        break;
                }
            }

            if (isHealthy)
            {
                Console.WriteLine("You've made it!");
                Console.WriteLine($"Bitcoins: {bitcoins}");
                Console.WriteLine($"Health: {healt}");
            }
        }
    }
}
