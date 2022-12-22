using System;

namespace L05._Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i =1; i <= number; i++)
            {
                int num = i;
                int sum = 0;
                while (num != 0)
                {
                    int curent = num % 10;
                    num = num / 10;
                    sum += curent;
                }

                if (sum==5 || sum ==7 || sum==11)
                {
                    Console.WriteLine($"{i} -> True");
                }
                else
                {
                    Console.WriteLine($"{i} -> False");
                }
            }
        }
    }
}
