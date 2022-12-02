using System;

namespace _02._Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string projections = Console.ReadLine();
            int r = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            double price = 0;
            double totalPrice = 0;
            if(projections == "Premiere")
            {
                price = 12.00;
                totalPrice = r * c * price;
            }
            if (projections == "Normal")
            {
                price = 7.50;
                totalPrice = r * c * price;
            }
            if (projections == "Discount")
            {
                price = 5.00;
                totalPrice = r * c * price;
            }
            Console.WriteLine($"{totalPrice:F2} leva");
        }
    }
}
