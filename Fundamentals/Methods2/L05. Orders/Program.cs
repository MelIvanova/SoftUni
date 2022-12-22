using System;

namespace L05._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int amount = int.Parse(Console.ReadLine());
            double price = 0.0;
            switch (product)
            {
                case "coffee":
                    price = 1.50;
                    CoffeeCost(amount, price);
                    break;
                case "coke":
                    price = 1.40;
                    CokeCost(amount, price);
                    break;
                case "water":
                    price = 1.00;
                    WaterCost(amount, price);
                    break;
                case "snacks":
                    price = 2.00;
                    SnacksCost(amount, price);
                    break;
            }
        }

        private static void SnacksCost(int amount, double price)
        {
            Console.WriteLine($"{(amount * price):F2}");
        }

        private static void WaterCost(int amount, double price)
        {
            Console.WriteLine($"{(amount*price):F2}");
        }

        private static void CokeCost(int amount, double price)
        {
            Console.WriteLine($"{(amount * price):F2}");
        }

        private static void CoffeeCost(int amount, double price)
        {
            Console.WriteLine($"{(amount * price):F2}");
        }
    }
}
