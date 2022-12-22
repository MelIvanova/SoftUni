using System;

namespace _08._Letters_Change_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] gameContaince = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            double result = 0.0;

            for (int i = 0; i < gameContaince.Length; i++)
            {
                string current = gameContaince[i];
                string sub = current.Substring(1, current.Length - 2);
                int firstNum = 0;
                int secondNum = 0;
                double digit = double.Parse(sub);
                double sum = 0.0;
                if (current[0] >= 65 && current[0] <= 90)
                {
                    firstNum = current[0] - 64;
                    sum = digit / firstNum;
                }
                else if (current[0] >= 97 && current[0] <= 122)
                {
                    firstNum = current[0] - 96;
                    sum = digit * firstNum;
                }

                if (current[current.Length-1] >= 65 && current[current.Length - 1] <= 90)
                {
                    secondNum = current[current.Length - 1] - 64;
                    sum = sum - secondNum;
                }
                else if (current[current.Length - 1] >= 97 && current[current.Length - 1] <= 122)
                {
                    secondNum = current[current.Length - 1] - 96;
                    sum = sum + secondNum;
                }
                result += sum;
            }

            Console.WriteLine($"{result:F2}");
        }
    }
}
