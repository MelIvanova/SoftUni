using System;

namespace _001FirstProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            double neededExperiance = double.Parse(Console.ReadLine());
            int battles = int.Parse(Console.ReadLine());
            double currentEperiance;
            double experianceGain=0.0;
            int battlesWon=0;

            for (int i = 0; i < battles; i++)
            {
                currentEperiance = double.Parse(Console.ReadLine());
                if (experianceGain<neededExperiance)
                {
                    battlesWon++;
                    experianceGain += currentEperiance;
                    if (battlesWon%3==0)
                    {
                        experianceGain += currentEperiance * 0.15;
                    }
                    if (battlesWon%5==0)
                    {
                        experianceGain -= currentEperiance * 0.10;
                    }
                    if (battlesWon%15==0)
                    {
                        experianceGain += currentEperiance * 0.05;
                    }
                   
                }
                if (experianceGain>=neededExperiance)
                {
                    break;
                }
            }
            if (experianceGain >= neededExperiance)
            {
                Console.WriteLine($"Player successfully collected his needed experience for {battlesWon} battles.");
            }
            else
            {
                double needMore = neededExperiance - experianceGain;
                Console.WriteLine($"Player was not able to collect the needed experience, {needMore:F2} more needed.");
            }
        }       
    }
}
