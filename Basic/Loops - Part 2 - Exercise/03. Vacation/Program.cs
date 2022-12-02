using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double travelExpence = double.Parse(Console.ReadLine());
            double moneyHave = double.Parse(Console.ReadLine());
            int dayCount = 0;
            int spendingCount = 0;
            while (travelExpence > moneyHave)
            {
                string action = Console.ReadLine();
                double daylyMoney = double.Parse(Console.ReadLine());
                dayCount++;
                if (action == "save")
                {
                    moneyHave += daylyMoney;
                    spendingCount = 0;
                }
                else if (action == "spend")
                {
                    moneyHave -= daylyMoney;
                    spendingCount++;
                }
                if (moneyHave < 0)
                {
                    moneyHave = 0;
                }
                if (spendingCount == 5)
                {
                    Console.WriteLine("You can't save the money.");
                    Console.WriteLine(dayCount);
                    break;
                }

            }
            if (moneyHave >= travelExpence)
            {
                Console.WriteLine($"You saved the money for {dayCount} days.");
            }


        }
    }
}
