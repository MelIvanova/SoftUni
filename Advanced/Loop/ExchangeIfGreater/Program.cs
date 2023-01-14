using System;

namespace ExchangeIfGreater
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNum = double.Parse(Console.ReadLine());
            double secondNum = double.Parse(Console.ReadLine());

            if (firstNum > secondNum)
            {
                double current = firstNum;
                firstNum = secondNum;
                secondNum = current;
            }

            Console.WriteLine($"{firstNum} {secondNum}");
        }
    }
}
