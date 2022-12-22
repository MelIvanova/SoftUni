using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp99
{
    class Program
    {
        static void Main(string[] args)
        {

            int peopleWaiting = int.Parse(Console.ReadLine());
            List<int> lift = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            for (int i = 0; i < lift.Count; i++)
            {
                if (lift[i] == 0)
                {
                    if (peopleWaiting - 4 < 0)
                    {
                        if (peopleWaiting - 3 < 0)
                        {
                            if (peopleWaiting - 2 < 0)
                            {
                                if (peopleWaiting - 1 < 0)
                                {
                                    break;
                                }
                                else
                                {
                                    lift[i] += 1;
                                    peopleWaiting -= 1;
                                }
                            }
                            else
                            {
                                lift[i] += 2;
                                peopleWaiting -= 2;
                            }
                        }
                        else
                        {
                            lift[i] += 3;
                            peopleWaiting -= 3;
                        }
                    }
                    else
                    {
                        lift[i] += 4;
                        peopleWaiting -= 4;
                    }
                }
                else if (lift[i] == 1)
                {
                    if (peopleWaiting - 3 < 0)
                    {
                        if (peopleWaiting - 2 < 0)
                        {
                            if (peopleWaiting - 1 < 0)
                            {
                                break;
                            }
                            else
                            {
                                lift[i] += 1;
                                peopleWaiting -= 1;
                            }
                        }
                        else
                        {
                            lift[i] += 2;
                            peopleWaiting -= 2;
                        }
                    }
                    else
                    {
                        lift[i] += 3;
                        peopleWaiting -= 3;
                    }
                }
                else if (lift[i] == 2)
                {
                    if (peopleWaiting - 2 < 0)
                    {
                        if (peopleWaiting - 1 < 0)
                        {
                            break;
                        }
                        else
                        {
                            lift[i] += 1;
                            peopleWaiting -= 1;
                        }
                    }
                    else
                    {
                        lift[i] += 2;
                        peopleWaiting -= 2;
                    }
                }
                else if (lift[i] == 3)
                {
                    if (peopleWaiting - 1 < 0)
                    {
                        break;
                    }
                    else
                    {
                        lift[i] += 1;
                        peopleWaiting -= 1;
                    }
                }
                else if (lift[i] == 4)
                {
                    continue;
                }
            }
            if (peopleWaiting > 0)
            {
                Console.WriteLine($"There isn't enough space! {peopleWaiting} people in a queue!");
                Console.WriteLine(string.Join(" ", lift));
            }
            else
            {
                if (lift.Sum() % 4 == 0)
                {
                    Console.WriteLine(string.Join(" ", lift));
                }
                else
                {
                    Console.WriteLine("The lift has empty spots!");
                    Console.WriteLine(string.Join(" ", lift));
                }
            }


        }
    }
}