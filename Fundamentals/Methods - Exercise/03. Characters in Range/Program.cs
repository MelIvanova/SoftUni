
using System;
using System.Collections.Generic;

namespace _03._Characters_in_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            char inputStart = char.Parse(Console.ReadLine());
            char inputEnd = char.Parse(Console.ReadLine());
            List<char> result = ReturnCharInRange(inputStart, inputEnd);
            Console.WriteLine(string.Join(" ",result));
        }

         static List<char> ReturnCharInRange(char input, char input2)
        {
            List<char> Range = new List<char>();
            if (input>input2)
            {
                char temp = input2;
                input2 = input;
                input = temp;
            }
            
            for (char i = input; i < input2; i++)
            {
                if (i==input)
                {
                    continue;
                }
                    Range.Add(i);
            }
            return Range;
        }
    }
}
