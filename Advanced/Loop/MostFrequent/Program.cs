using System;
using System.Linq;

namespace MostFrequent
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

            Array.Sort(numbers);
            
            int frequentNum = 0;
            int repeatedTimes = 1;
       
            for (int j = 0; j < n-1; j++)
            {
                int occurrences = numbers.Count(x => x == numbers[j]);

                if (occurrences > repeatedTimes)
                {
                    repeatedTimes = occurrences;
                    frequentNum = numbers[j];
                }
            }
            
            Console.WriteLine($"{frequentNum} ({repeatedTimes} times)");
        }
    }
}
