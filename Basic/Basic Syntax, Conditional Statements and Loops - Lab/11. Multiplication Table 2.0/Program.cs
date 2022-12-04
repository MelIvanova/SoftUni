using System;

namespace _11._Multiplication_Table_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int multiplier = int.Parse(Console.ReadLine());
            int times = int.Parse(Console.ReadLine());
            int result = 0;
            for ( int times1 = times ; times1 <= 10; times1++)
            {
                result = multiplier * times1;
                Console.WriteLine($"{multiplier} X {times1} = {result}");
            }
            if (times > 10)
            {
                result = multiplier * times;
                Console.WriteLine($"{multiplier} X {times} = {result}");
            }
        }
    }
}
