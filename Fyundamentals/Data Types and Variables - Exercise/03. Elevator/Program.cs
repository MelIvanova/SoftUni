﻿using System;

namespace _03._Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());
            int courses = people / capacity;
            if (people%capacity!=0)
            {
                courses++;
            }
            Console.WriteLine($"{courses}");
        }
    }
}
