using System;

namespace LongestSequenceOfEqual
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            int sequence = 0;
            int current = 1;

            for (int i = 0; i < n - 1; i++)
            {
                if (numbers[i] != numbers[i + 1])
                {
                    current = 0;
                }
                current++;

                if (sequence < current)
                {
                    sequence = current;
                }
            }

            if (sequence == 1 && current == 1)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(sequence);
            }

        }
    }
}
