using System;

namespace _02._Half_Sum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            //"Yes", "Sum = "
            //"No", "Diff = 
            int n = int.Parse(Console.ReadLine());
            int bigest = int.MinValue;
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                sum += number;
                if(bigest<number)
                {
                    bigest = number;
                }

            }
            int sumTotal = sum - bigest;
            if(bigest==sumTotal)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {sumTotal}");
            }
            else
            {
                double diff = Math.Abs(sumTotal - bigest);
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {diff}");
            }
        }
    }
}