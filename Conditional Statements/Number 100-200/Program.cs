﻿using System;

namespace Number_100_200
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            if (number < 100)
            {
                Console.WriteLine("Less than 100");
            }
            if (number > 200)
            {
                Console.WriteLine("Greater than 200");
            }
            if (number >= 100 && number <= 200)
            {
                Console.WriteLine("Between 100 and 200");
            }
          
             


        }
    }
}
