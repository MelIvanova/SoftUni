using System;

namespace MidExamFundSept
{
    class Program
    {
        static void Main(string[] args)
        {
            double jurneyCost = double.Parse(Console.ReadLine());
            int months = int.Parse(Console.ReadLine());
            double save = 0;
            double spend = 0;
            double bonus = 0;

            for (int i = 1; i <= months; i++)
            {
                if (i > 1 && i % 2 != 0)
                {
                    spend = save * 0.16;
                    save = save - spend;
                    save += jurneyCost * 0.25;
                }
                else if (i % 4 == 0)
                {
                    bonus = save * 0.25;
                    save += jurneyCost * 0.25 + bonus;
                }
                else
                {
                    save += jurneyCost * 0.25;
                }
            }

            if (save>=jurneyCost)
            {
                double souvenirsMoney = save - jurneyCost;
                Console.WriteLine($"Bravo! You can go to Disneyland and you will have {souvenirsMoney:F2}lv. for souvenirs.");
            }
            else
            {
                double moneyNeed = jurneyCost - save;
                Console.WriteLine($"Sorry. You need {moneyNeed:F2}lv. more.");
            }
        }
    }
}
