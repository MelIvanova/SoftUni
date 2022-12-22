using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] letters = input.ToCharArray();
           

            for (int i = 0; i < letters.Length; i++)
            {
                letters[i] = (char)(letters[i] + 3);
            }

            Console.WriteLine(string.Join("",letters)) ;

        }
    }
}
