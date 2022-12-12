using System;
using System.Linq;

namespace _05._Sum_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int sum = 0;

            foreach (int n in numbers)
            {
                if (n%2==0)
                {
                    sum += n;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
