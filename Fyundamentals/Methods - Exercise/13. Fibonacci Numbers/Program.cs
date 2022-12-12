using System;

namespace _13._Fibonacci_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int result = GetFibonachiResult(num);
            Console.WriteLine(result);
        }

        static int GetFibonachiResult(int num)
        {
            int a = 1;
            int b = 1;
            int result = 0;
            if (num == 0 || num == 1)
            {
                result = 1;
            }
            else
            {
                for (int i = 2; i <= num; i++)
                {
                    result = a + b;
                    a = b;
                    b = result;
                }
            }
            
            return result;
        }
    }
}
