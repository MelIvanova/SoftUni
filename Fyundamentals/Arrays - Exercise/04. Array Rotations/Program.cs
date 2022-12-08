using System;

namespace _04._Array_Rotations
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] num = Console.ReadLine().Split();
            int rotation = int.Parse(Console.ReadLine());
            for (int i = 0; i < rotation; i++)
            {
                string temp = num[0];
                for (int j = 0; j < num.Length-1; j++)
                {
                    num[j] = num[j + 1];
                }
                num[num.Length - 1] = temp;
            }
            Console.WriteLine(string.Join(" ",num));
        }
    }
}
