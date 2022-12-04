using System;

namespace _06._Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int a = 1; a <= n&& a <= 9; a++)
            {
                    for (int b = 1; b <= n&& b <= 9; b++)
                    {
                            for (int c = 1; c <= n && c <= 9; c++)
                            {
                              
                                    for (int d = 1; d <= n && d <= 9; d++)
                                    {
                                        if (n % a == 0 &&  n % b == 0 &&  n % c == 0  && n%d==0 )
                                        {
                                            
                                            Console.Write($"{a}{b}{c}{d} ");
                                        }
                                    }
                            }
                    }
            }
        }
    }
}
