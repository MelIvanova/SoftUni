using System;

namespace _701._Easter_Cozonacs
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            double flourPrice = double.Parse(Console.ReadLine());
            int cozonacs = 0;
            int coloredEggs = 0;
            double eggsPrice = flourPrice * 0.75;
            double milkPrice = (flourPrice + (flourPrice * 0.25)) / 4.0;
            double cozonacsPrice = flourPrice + eggsPrice + milkPrice;

            while (money>=cozonacsPrice)
            {
                money -= cozonacsPrice;
                cozonacs++;
                coloredEggs += 3;
                if (cozonacs%3==0)
                {
                    coloredEggs -= (cozonacs - 2);
                }
            }
            Console.WriteLine($"You made {cozonacs} cozonacs! Now you have {coloredEggs} eggs and {money:f2}BGN left.");
        }
    }
}
