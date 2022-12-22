using System;

namespace L10._Lower_or_Upper
{
    class Program
    {
        static void Main(string[] args)
        {
            char letter = char.Parse(Console.ReadLine());

            if (letter>=65 && letter<=90)
            {
                Console.WriteLine("upper-case");
            }
            else if(letter>=97 && letter <= 122)
            {
                Console.WriteLine("lower-case");
            }
        }
    }
}
