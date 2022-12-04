using System;

namespace _05._Password_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            int ascii = 96;
            

            for (int i = 1; i <= n; i++)
            {
                for (int m = 1; m <= n; m++)
                {
                    for (char k = 'a'; k <= ascii+l; k++)
                    {
                        for (char o = 'a' ; o <= ascii + l; o++)
                        {
                            for (int p = 2; p <= n; p++)
                            {
                                if (p > i && p > m)
                                {
                                     Console.Write($"{i}{m}{k}{o}{p} ");
                                }
                               
                            }
                        }
                    }
                }
            }
        }
    }
}
