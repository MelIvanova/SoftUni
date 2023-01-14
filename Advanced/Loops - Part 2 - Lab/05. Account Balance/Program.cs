using System;

namespace _05._Account_Balance
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            int inputs = int.Parse(Console.ReadLine());
            double sum = 0;
            while (i<=inputs)
            {
                double value = double.Parse(Console.ReadLine());
               
                if(value<=0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                Console.WriteLine($"Increase: {value:F2}");
                sum += value;
                i++;
            }
            Console.WriteLine($"Total: {sum:F2}");
        }
    }
}
