using System;
using System.Linq;

namespace _08._Magic_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int magicSum = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < numbers.Length-1; i++)
            {
                
                for (int j = 1+i; j < numbers.Length; j++)
                {
                    sum = numbers[i] + numbers[j];

                    if (sum == magicSum)
                    {
                        Console.WriteLine($"{numbers[i]} {numbers[j]}");
                        sum = 0;
                        break;
                    }
                    else
                    {
                        sum = 0;
                    }
                } 
            }
        }
    }
}
