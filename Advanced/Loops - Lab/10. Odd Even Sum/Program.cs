using System;

namespace _10._Odd_Even_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int n = int.Parse(Console.ReadLine());
            int sum1 = 0;
            int sum2 = 0;
            for (int i = 1; i <= n; i++)
            {
                int numbers = int.Parse(Console.ReadLine());
                if(i%2==0)
                {
                    sum1 = sum1 + numbers;
                }
                else if(i%2!=0)
                {
                    sum2 = sum2 + numbers;
                }
            }
            if(sum1==sum2)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {Math.Abs(sum1)}");
            }
            else
            {
                int diff = Math.Abs(sum1 - sum2);
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {diff}");
            }


        }
    }
}
