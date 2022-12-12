using System;
using System.Linq;

namespace _06._Even_and_Odd_Subtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int even = 0;
            int odd = 0;
            int diff = 0;
            foreach (int num in numbers)
            {
                
                if (num%2==0)
                {
                    even += num;
                }
                else
                {
                    odd += num;
                }
            }
            diff = even - odd;
            Console.WriteLine(diff);
        }
    }
}
