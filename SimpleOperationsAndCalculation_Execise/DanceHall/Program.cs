using System;

namespace DanceHall
{
    class Program
    {
        static void Main(string[] args)
        {
            double L = double.Parse(Console.ReadLine());
            double W = double.Parse(Console.ReadLine());
            double A = double.Parse(Console.ReadLine());

            double dansHall = (L * 100) * (W * 100);
            double wardroube = (A*100) * (A*100);
            double bench = dansHall / 10;
            double freeSpace = dansHall - wardroube - bench;
            double dancers = freeSpace / (40 + 7000);
            Console.WriteLine(Math.Floor(dancers));



        }
    }
}
