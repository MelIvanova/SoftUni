using System;

namespace _05._Add_and_Subtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int one = int.Parse(Console.ReadLine());
            int two = int.Parse(Console.ReadLine());
            int three = int.Parse(Console.ReadLine());
            int sum = SumOfTwo(one, two);
            int result = Subtracts(sum, three);
            Console.WriteLine(result);
        }

        private static int Subtracts(int sum, int three)
        {
            int result = sum - three;
            return result;
        }

        private static int SumOfTwo(int one, int two)
        {
            int result = one + two;
            return result;
        }
    }
}
