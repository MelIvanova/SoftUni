using System;

namespace _11._Clever_Lily
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double washingMachine = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());
            double giftMoney = 0;
            int brother = 0;
            int toys = 0;
            double allGiftMoney = 0;
            for (int i = 1; i <= age; i++)
            {
                if(i%2==0)
                {
                   
                    giftMoney =  giftMoney + 10.00;
                    brother++;
                    allGiftMoney += giftMoney;
                }
                else
                {
                    toys ++;
                }
            }
            double sumMoney = allGiftMoney - brother;
            double toyMoney = toys * toyPrice;
            bool yes = washingMachine <= (sumMoney + toyMoney);
            if (yes)
            {
                double diff1 = (sumMoney + toyMoney) - washingMachine;
                Console.WriteLine($"Yes! {diff1 :F2}");
            }
            else if (!yes)
            {
                double diff2 = washingMachine - (sumMoney + toyMoney);
                Console.WriteLine($"No! {diff2 :F2}");
            }

        }
    }
}
