using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._String_Explosion
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int range = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (range > 0 && input[i] !='>')
                {
                    input = input.Remove(i, 1);
                    range--;
                    i--;
                }
                else if (input[i]=='>')
                {
                    range += int.Parse(input[i + 1].ToString());
                }
            }

            Console.WriteLine(input);
        }
    }
}
