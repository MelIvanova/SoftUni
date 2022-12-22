using System;
using System.Linq;

namespace _04._Array_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int move = int.Parse(Console.ReadLine());
            int[] result = new int[array.Length];
            int last = 0;

            for (int i = 1; i <= move; i++)
            {
                last = array[0];
                for (int j = 1; j < array.Length; j++)
                {
                    result[j-1] = array[j];

                }
                result[result.Length-1] = last;
                array = result;
            }

            Console.WriteLine(string.Join(" ",array));
        }
    }
}
