using System;

namespace _05._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            decimal price = 0m;

            switch (product)
            {
                case "coffee":
                    price = 1.50m;
                    Coffee(quantity, price);
                    break;
                case "water":
                    price = 1.00m;
                    Water(quantity, price);
                    break;
                case "coke":
                    price = 1.40m;
                    Coke(quantity, price);
                    break;
                case "snacks":
                    price = 2.00m;
                    Snacks(quantity, price);
                    break;
            }

            static void Coffee(int a,decimal b)
            {
                Console.WriteLine($"{a * b:F2}");
            }

            static void Water(int a, decimal b)
            {
                Console.WriteLine($"{a*b:F2}");
            }

            static void Coke(int a, decimal b)
            {
                Console.WriteLine($"{a * b:F2}");
            }

            static void Snacks(int a, decimal b)
            {
                Console.WriteLine($"{a * b:F2}");
            }
        }
    }
}
