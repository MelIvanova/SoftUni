using System;

namespace _08._Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal number = decimal.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            PowerNum(number, power);
            decimal result = PowerNum(number, power);
            Console.WriteLine(result);
        }

        static decimal PowerNum(decimal number, int power)
        {
            decimal result = 1M;
            for (double i = 1; i <= power; i++)
            {
                result = result * number;
            }
            return result;
        }
    }
}
