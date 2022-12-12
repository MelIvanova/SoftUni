using System;
using System.Linq;

namespace _01._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] train = new int[int.Parse(Console.ReadLine())];
            int sum = 0;
            for (int i = 0; i < train.Length; i++)
            {
                int pasengers = int.Parse(Console.ReadLine());
                train[i] = pasengers;
                sum += pasengers;
            }
            Console.WriteLine(string.Join(" ", train));
            Console.WriteLine(sum);
        }
    }
}
