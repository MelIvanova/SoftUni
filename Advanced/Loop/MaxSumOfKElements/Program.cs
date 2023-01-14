using System;

namespace MaxSumOfKElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            int bigestNum = int.MinValue;
            int result = 0;
            int index = 0;

            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (numbers[j]>bigestNum)
                    {
                        bigestNum = numbers[j];
                        index = j;
                    }
                }

                result += bigestNum;
                bigestNum = int.MinValue;
                numbers[index] = bigestNum;
            }

            Console.WriteLine(result);
        }
    }
}
