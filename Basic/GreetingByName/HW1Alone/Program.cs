using System;

namespace HW1Alone
{
    class Program
    {
        static void Main(string[] args)
        {
            int inches = int.Parse(Console.ReadLine());
            double transform = double.Parse(Console.ReadLine());
            Console.WriteLine(inches * transform);

        }
    }
}
