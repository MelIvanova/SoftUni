using System;

namespace _06._Triples_of_Latin_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                for (int m = 0; m < number; m++)
                {
                    for (int j = 0; j < number; j++)
                    {
                        char firstChar =(char)('a' + i);
                        char secondChar = (char)('a' + m);
                        char thirdChar = (char)('a' + j);
                        Console.WriteLine($"{firstChar}{secondChar}{thirdChar}");
                    }

                }
            }
        }
    }
}
