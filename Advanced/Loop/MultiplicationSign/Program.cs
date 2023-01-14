using System;

namespace MultiplicationSign
{
    class Program
    {
        static void Main(string[] args)
        {
            double fitst = double.Parse(Console.ReadLine());
            double second = double.Parse(Console.ReadLine());
            double third = double.Parse(Console.ReadLine());

            double sum = fitst * second * third;

            if (sum < 0)
            {
                Console.WriteLine('-');
            }
            else if (sum > 0)
            {
                Console.WriteLine('+');
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
