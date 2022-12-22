using System;

namespace M04._Reverse_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string output = "";

            for (int i = input.Length -1; i >= 0; i--)
            {
                output = output + input[i];
            }

            Console.WriteLine(output);
        }
    }
}
