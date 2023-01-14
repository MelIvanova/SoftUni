using System;
using System.Linq;

namespace A04._Add_VAT
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] price = Console.ReadLine().Split(", ").Select(double.Parse).Select(p => p + (p * 0.2)).ToArray();

            foreach (var p in price)
            {
                Console.WriteLine($"{p:f2}");
            }
        }
    }
}
