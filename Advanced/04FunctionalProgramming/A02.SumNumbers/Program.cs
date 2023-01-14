using System;
using System.Linq;

namespace A02.SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            Func<int[], int> results = Sum;
            int sum = results(numbers);
            results = Count;
            int count = results(numbers);
            Console.WriteLine(count);
            Console.WriteLine(sum);
        }

        static int Sum(int[] numbers)
        {
            int sum = 0;
            foreach (var num in numbers)
            {
                sum += num;
            }
            return sum;
        }

        static int Count (int [] numbers)
        {
            int count = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                count++;
            }

            return count;
        }
    }
}
