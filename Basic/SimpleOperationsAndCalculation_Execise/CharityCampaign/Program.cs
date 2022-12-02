using System;

namespace CharityCampaign
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int bakers = int.Parse(Console.ReadLine());
            int cake = int.Parse(Console.ReadLine());
            int waffles = int.Parse(Console.ReadLine());
            int pancakes = int.Parse(Console.ReadLine());

            double cakePriceDay = cake * 45;
            double wafflesPriceDay = waffles * 5.80;
            double panecakesPriceDay = pancakes * 3.20;

            double dayIncomes = (cakePriceDay + wafflesPriceDay + panecakesPriceDay) * bakers;
            double allIncomes = dayIncomes * days;

            Console.WriteLine($"{allIncomes - (allIncomes/8):F2}");


        }
    }
}
