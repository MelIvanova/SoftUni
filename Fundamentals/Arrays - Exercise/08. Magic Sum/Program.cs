using System;
using System.Linq;

namespace _08._Magic_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int result = int.Parse(Console.ReadLine());
            int index = 0;
            int lenght = numbers.Length-1;
            for (int i = lenght; i > 0; i--)
            {
                while (i>0)
                {
                    for (int m = index; m < numbers.Length-1; m++)
                    {
                        if (numbers[index] + numbers[m+1] == result)
                        {
                            Console.WriteLine(numbers[index] + " " + numbers[m+1]);
                        }
                        i--;
                    }
                    
                }
                index++;
                i = lenght - index +1;
            }
        }
    }
}
