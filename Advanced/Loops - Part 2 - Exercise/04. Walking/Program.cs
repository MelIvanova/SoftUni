using System;

namespace _04._Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            string goal = Console.ReadLine(); 
            int steps = 0;
            int allSteps = 0;
            int diff = 0;
            while (goal!= "Going home")
            {
                steps = int.Parse(goal);
                allSteps += steps;
                if (allSteps>=10000)
                {
                    Console.WriteLine("Goal reached! Good job!");
                    break;
                }
                goal = Console.ReadLine();
            }
            if (goal == "Going home")
            {
                int lastSreps = int.Parse(Console.ReadLine());
                allSteps += lastSreps;
                if (allSteps >= 10000)
                {
                    Console.WriteLine("Goal reached! Good job!");

                }
                else
                {
                    diff = 10000 - allSteps;
                    Console.WriteLine($"{diff} more steps to reach goal.");
                }
            }

        }
        }
    }

