using System;
using System.Linq;

namespace L08._Condense_Array_to_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split()
                .Select(int.Parse).ToArray();
            int[] condence = new int[numbers.Length - 1];

            while (numbers.Length!=1)
            {
                for (int i = 0; i < numbers.Length-1; i++)
                {
                    condence[i] = numbers[i] + numbers[i + 1];
                }
                numbers = condence;
                condence= new int[numbers.Length - 1];
            }

            Console.WriteLine(numbers[0]);
            
        }
    }
}
