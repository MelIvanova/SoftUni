﻿using System;

namespace _05._Divide_Without_Remainder
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double p1 = 0.0;//%2
            double p2 = 0.0;//%3
            double p3 = 0.0;//%4
            for (int i =1 ; i <= n; i++)
            {
                double numbers = double.Parse(Console.ReadLine());
                if(numbers % 2 == 0)
                {
                    p1 ++;
                }
                if(numbers%3==0)
                {
                    p2 ++;
                }
                if(numbers%4==0)
                {
                    p3 ++;
                }
            }
            p1 = p1 / n * 100;
            p2 = p2 / n * 100;
            p3 = p3 / n * 100;
            Console.WriteLine($"{p1:f2}%");
            Console.WriteLine($"{p2:f2}%");
            Console.WriteLine($"{p3:f2}%");
        }
    }
}
