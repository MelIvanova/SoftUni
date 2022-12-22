using System;
using System.Linq;

namespace _05._Top_Integer
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            bool isBigger = false;
            string bigNumbers = string.Empty;

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 1 + i; j < numbers.Length; j++)
                {
                    if (numbers[i] <= numbers[j])
                    {
                        isBigger = false;
                        break;
                    }
                    else
                    {
                        isBigger = true;
                    }
                }

                if (isBigger && i< numbers.Length-1)
                {
                    bigNumbers += numbers[i] + " ";
                }
                else if(i == numbers.Length - 1)
                {
                    bigNumbers += numbers[i];
                }
            }
          
            Console.WriteLine(bigNumbers);
        }
    }
}
