using System;

namespace _02._Print_Numbers_in_Reverse_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            int range = int.Parse(Console.ReadLine());
            int[] input = new int[range];
            for (int i = 0; i < range; i++)
            {
                input[i] = int.Parse(Console.ReadLine());
               
               
            }
            for (int i = input.Length-1; i >= 0; i--)
            {
                Console.Write(input[i]+" ");
            }
            
        }

    }
}
