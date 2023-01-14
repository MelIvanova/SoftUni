using System;

namespace _09._Left_and_Right_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            //Yes, sum = " + сумата
            //No, diff = " + разликата
            int n = int.Parse(Console.ReadLine());
            int sum1 = 0;
            for (int i = 0; i < n; i++)
            {
                int numbers = int.Parse(Console.ReadLine());
                sum1 = sum1 + numbers;
            }
            int sum2 = 0;
            for (int i = 0; i < n; i++)
            {
                int numbers = int.Parse(Console.ReadLine());
                sum2 = sum2 + numbers;
            }
            if(sum1==sum2)
            {
                Console.WriteLine($"Yes, sum = {Math.Abs(sum1)}");
            }
            else
            {
                int difrense = Math.Abs(sum1 - sum2);
                Console.WriteLine($"No, diff = {difrense}");
            }
        }
    }
}
