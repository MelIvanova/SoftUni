using System;

namespace _06._Triples_of_Latin_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                char first = (char)('a' + i);
                
                for (int j = 0; j < num; j++)
                {
                    char second = (char)('a' + j);
                    for (int k = 0; k < num; k++)
                    {
                        char third = (char)('a' + k);
                        Console.WriteLine($"{first}{second}{third}");
                    }
                }
                
            }
        }
    }
}
