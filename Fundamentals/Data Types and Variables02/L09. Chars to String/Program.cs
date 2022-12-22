using System;

namespace L09._Chars_to_String
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string result = string.Empty;

            for (int i = 0; i < 3; i++)
            {
                char input = char.Parse(Console.ReadLine());
                result += input;
            }
            Console.WriteLine(result);
        }
    }
}
