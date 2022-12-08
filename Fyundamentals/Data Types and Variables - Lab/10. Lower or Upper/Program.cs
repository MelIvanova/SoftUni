using System;

namespace _10._Lower_or_Upper
{
    class Program
    {
        static void Main(string[] args)
        {
            char simbol = char.Parse(Console.ReadLine());
            if (simbol >=97)
            {
                Console.WriteLine("lower-case");
            }
            else
            {
                Console.WriteLine("upper-case");
            }
        }
    }
}
