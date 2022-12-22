using System;
using System.Collections.Generic;
using System.Linq;

namespace _102._Archery_Tournament
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> targetsField = Console.ReadLine()
                                .Split('|', StringSplitOptions.RemoveEmptyEntries)
                                .Select(int.Parse)
                                .ToList();
            string[] command = Console.ReadLine()
                                .Split('@', StringSplitOptions.RemoveEmptyEntries);

            int points = 0;
            while (command[0] != "Game over")
            {

                if (command[0] == "Shoot Left")
                {
                    int indexLeft = int.Parse(command[1]);
                    int length = int.Parse(command[2]);
                    if (indexLeft >= 0 && indexLeft < targetsField.Count)
                    {
                        for (int i = 1; i <= length; i++)
                        {
                            indexLeft--;
                            if (indexLeft == -1)
                            {
                                indexLeft = targetsField.Count - 1;
                            }
                        }
                        if (targetsField[indexLeft] < 5)
                        {
                            points += targetsField[indexLeft];
                            targetsField[indexLeft] = 0;
                        }
                        else
                        {
                            targetsField[indexLeft] -= 5;
                            points += 5;
                        }

                    }
                }
                else if (command[0] == "Shoot Right")
                {
                    int infexRigth = int.Parse(command[1]);
                    int length = int.Parse(command[2]);
                    if (infexRigth >= 0 && infexRigth < targetsField.Count)
                    {
                        for (int i = 1; i <= length; i++)
                        {
                            infexRigth++;
                            if (infexRigth == targetsField.Count)
                            {
                                infexRigth = 0;
                            }
                        }
                        if (targetsField[infexRigth] < 5)
                        {
                            points += targetsField[infexRigth];
                            targetsField[infexRigth] = 0;
                        }
                        else
                        {
                            targetsField[infexRigth] -= 5;
                            points += 5;
                        }

                    }
                }
                else if (command[0] == "Reverse")
                {
                    targetsField.Reverse();
                }

                command = Console.ReadLine()
                                .Split('@', StringSplitOptions.RemoveEmptyEntries);
            }

            Console.WriteLine(string.Join(" - ", targetsField));
            Console.WriteLine($"Iskren finished the archery tournament with {points} points!");
        }
    }
}

