using System;

namespace AllocateArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = (i) * 5;
            }

            foreach (int item in numbers)
            {
                Console.WriteLine(item);
            }
        }
    }
}
