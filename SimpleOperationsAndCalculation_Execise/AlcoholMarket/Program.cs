using System;

namespace AlcoholMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceWiskey = double.Parse(Console.ReadLine());
            double beer = double.Parse(Console.ReadLine());
            double wine = double.Parse(Console.ReadLine());
            double rakia = double.Parse(Console.ReadLine());
            double wiskey = double.Parse(Console.ReadLine());

            double priceRakia = priceWiskey / 2;
            double priceWine = priceRakia - 0.4 * priceRakia;
            double priceBeer = priceRakia - 0.8 * priceRakia;

            double sumRakia = priceRakia * rakia;
            double sumWine = priceWine * wine;
            double sumBeer = priceBeer * beer;
            double sumWiskey = priceWiskey * wiskey;
            
            Console.WriteLine($"{sumBeer + sumRakia + sumWine + sumWiskey :F2}");

        }
    }
}
