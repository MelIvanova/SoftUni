using System;
using System.Numerics;

namespace _11._Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int snowballs = int.Parse(Console.ReadLine());
            BigInteger snowballPrep = 0;
            BigInteger snowballBest = 0;
            int bestSnow = 0;
            int bestTime = 0;
            int bestQuality = 0;

            for (int i = 0; i < snowballs; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());
                snowballPrep = BigInteger.Pow((snowballSnow / snowballTime), snowballQuality);

                if (snowballPrep>=snowballBest)
                {
                    snowballBest = snowballPrep;
                    bestSnow = snowballSnow;
                    bestTime = snowballTime;
                    bestQuality = snowballQuality;
                }
            }

            Console.WriteLine($"{bestSnow} : {bestTime} = {snowballBest} ({bestQuality})");
        }
    }
}
