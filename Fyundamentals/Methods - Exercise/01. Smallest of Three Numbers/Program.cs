using System;

namespace _01._Smallest_of_Three_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            SmallestInteger( num1, num2, num3);
            int result = SmallestInteger(num1, num2, num3);
            Console.WriteLine(result);

        }

        static int SmallestInteger(int num1, int num2, int num3)
        {
            int result = int.MaxValue;
            if (result>num1)
            {
                result = num1;
            }
            if (result>num2)
            {
                result = num2;
            }
            if (result>num3)
            {
                result = num3;
            }
            return result;
        }
    }
}
