using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Archery_Tournament
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine().Split('|').Select(int.Parse).ToList();
            string input = Console.ReadLine();
            int points = 0;
            while (input != "Game over")
            {
                string[] command = input.Split('@');
                if (command[0]== "Shoot Left")
                {
                    int countL = int.Parse(command[1]);
                    int length = int.Parse(command[2]);
                    if (countL>=0 && countL < targets.Count)
                    {
                        for (int i = 1; i <= length; i++)
                        {
                            countL--;
                            if (countL == -1)
                            {
                                countL = targets.Count - 1;
                            }
                        }
                        if (targets[countL] <5)
                        {
                            points += targets[countL];
                            targets[countL] = 0;
                        }
                        else
                        {
                            targets[countL] -= 5;
                            points += 5;
                        }
                       
                    }
                }
               else if (command[0] == "Shoot Right")
                {
                    int countR = int.Parse(command[1]);
                    int length = int.Parse(command[2]);
                    if (countR >=0 && countR < targets.Count)
                    {
                        for (int i = 1; i <= length; i++)
                        {
                            countR++;
                            if (countR == targets.Count)
                            {
                                countR = 0;
                            }
                        }
                        if (targets[countR] < 5)
                        {
                            points += targets[countR];
                            targets[countR] = 0;
                        }
                        else
                        {
                            targets[countR] -= 5;
                            points += 5;
                        }
                        
                    }
                }
                else if (command[0] == "Reverse")
                {
                    targets.Reverse();
                }

                    input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" - ",targets));
            Console.WriteLine($"Iskren finished the archery tournament with {points} points!");
        }
    }
}
