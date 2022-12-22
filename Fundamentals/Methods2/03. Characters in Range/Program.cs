using System;

namespace _03._Characters_in_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            char start = char.Parse(Console.ReadLine());
            char end = char.Parse(Console.ReadLine());

            CharectersBetwin(start, end);
        }

        private static void CharectersBetwin(char start, char end)
        {
            if (end<start)
            {
                char temp = start;
                start = end;
                end = temp;
            }
            for (int i = start+1; i < end; i++)
            {
                Console.Write($"{(char)i} ");
            }
        }
    }
}
