using System;

namespace Methods2
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());
            SmallestNum(firstNum, secondNum, thirdNum);
        }

         static void SmallestNum(int first, int second, int third)
        {
            int result = 0;

            if (first < second)
            {
                result = first;
                if (result > third)
                {
                    result = third;
                }
            }
            else
            {
                result = second;
                if (result > third)
                {
                    result = third;
                }
            }

            Console.WriteLine(result);
        }
    }
}
