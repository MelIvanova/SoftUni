using System;

namespace _04._Сума_от_две_числа
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());
            bool isReady = false;
            int counter = 0;
            int sum =0;
            for (int num1 = start; num1 <= end; num1++)
            {
                for (int num2 = start; num2 <= end; num2++)
                {
                    counter++;
                    sum = num1 + num2;
                    if (sum == magicNum)
                    {

                        Console.WriteLine($"Combination N:{counter} ({num1} + {num2} = {magicNum})");
                        isReady = true;
                        break;
                    }
                }
                if (isReady)
                {
                    break;
                }
            }
            if (sum!=magicNum)
            {
               Console.WriteLine($"{ counter} combinations - neither equals { magicNum}");
            }
            

        }
    }
}
