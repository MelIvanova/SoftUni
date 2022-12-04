using System;

namespace _03._Sum_Prime_Non_Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = "";
            bool isPrime = true;
            int primeSum = 0;
            int nonPrimeSum = 0;
            while ((num = Console.ReadLine()) != "stop")
            {
                isPrime = true;
                int number = int.Parse(num);
                if (number <0)
                {
                    Console.WriteLine("Number is negative.");
                    continue;
                }
                for (int i = 2; i <= Math.Sqrt(number); i++)
                {
                    if (number % i ==0)
                    {
                        isPrime = false;
                        nonPrimeSum += number;
                        break;
                    }
                }
                if (isPrime)
                {
                    primeSum += number;

                }
               
                
            }
            Console.WriteLine($"Sum of all prime numbers is: {primeSum}");
            Console.WriteLine($"Sum of all non prime numbers is: {nonPrimeSum}");
        }
    }
}
