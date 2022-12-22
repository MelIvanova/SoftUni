using System;

namespace _201._Counter_Strike
{
    class Program
    {
        static void Main(string[] args)
        {
            int energy = int.Parse(Console.ReadLine());
            int countOfWonBattles = 0;
            string distance = Console.ReadLine();
            bool isWin = true;

            while (distance != "End of battle")
            {
                int distansceToEnemy = int.Parse(distance);
                if (energy <= 0|| energy<distansceToEnemy)
                {
                    Console.WriteLine
                    ($"Not enough energy! Game ends with {countOfWonBattles} won battles and {energy} energy");
                    isWin = false;
                    break;
                }
                energy -= distansceToEnemy;
                countOfWonBattles++;
                if (countOfWonBattles % 3 == 0)
                {
                    energy += countOfWonBattles;
                }
                
                distance = Console.ReadLine();
            }
            if (isWin)
            {
                Console.WriteLine($"Won battles: {countOfWonBattles}. Energy left: {energy}");
            }

        }
    }
}
