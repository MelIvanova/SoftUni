using System;

namespace ExamePreparationFundamentalsMid
{
    class Program
    {
        static void Main(string[] args)
        {
            int biscuitsPerDay = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());
            int competingFactoriBiscuitsIn30Days = int.Parse(Console.ReadLine());
            int biscuitsAmoutMonth = 0;
            for (int i = 1; i <= 30; i++)
            {
                if (i%3 == 0)
                {
                    if (biscuitsPerDay>1)
                    {
                          biscuitsAmoutMonth += (int)(biscuitsPerDay * workers * 0.75);
                    }
                    else
                    {
                        continue;
                    }
                    
                }
                else
                {
                    biscuitsAmoutMonth += biscuitsPerDay * workers;
                }
            }
            Console.WriteLine($"You have produced {biscuitsAmoutMonth} biscuits for the past month.");
           
            if (competingFactoriBiscuitsIn30Days>biscuitsAmoutMonth)
            {
                decimal diff = competingFactoriBiscuitsIn30Days - biscuitsAmoutMonth;
                decimal percentLow = diff / competingFactoriBiscuitsIn30Days * 100;
                Console.WriteLine($"You produce {percentLow:F2} percent less biscuits.");
            }
            else
            {
                decimal dif = biscuitsAmoutMonth - competingFactoriBiscuitsIn30Days;
                decimal percentHie = dif / competingFactoriBiscuitsIn30Days * 100;
                Console.WriteLine($"You produce {percentHie:F2} percent more biscuits.");
            }
        }
    }
}
