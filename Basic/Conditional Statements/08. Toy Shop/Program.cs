using System;

namespace _08._Toy_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
           
            double vacationPrice = double.Parse(Console.ReadLine());
            int puzzels = int.Parse(Console.ReadLine());
            int doll = int.Parse(Console.ReadLine());
            int teddyBears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int lorry = int.Parse(Console.ReadLine());

            double puzzelsPrice = puzzels * 2.60;
            double dollPrice = doll * 3;
            double tedduBearsPrice = teddyBears * 4.10;
            double minionsPrice = minions * 8.20;
            double lorryPrice = lorry * 2;

            double totalPrice = puzzelsPrice + dollPrice + tedduBearsPrice + minionsPrice + lorryPrice;
            int totalToys = puzzels + doll + teddyBears + minions + lorry;

            if (totalToys >= 50)
            {
                totalPrice = totalPrice - totalPrice * 0.25;
            }

            totalPrice = totalPrice - totalPrice * 0.10;

            if (totalPrice >= vacationPrice)
            {
                Console.WriteLine($"Yes! {totalPrice - vacationPrice:F2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {vacationPrice - totalPrice:F2} lv needed.");
            }
        }
    }
}
