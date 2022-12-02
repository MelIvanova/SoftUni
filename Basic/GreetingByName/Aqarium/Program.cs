using System;

namespace Aqarium
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenth = int.Parse(Console.ReadLine());
            int wide = int.Parse(Console.ReadLine());
            int hight = int.Parse(Console.ReadLine());
            double persent = double.Parse(Console.ReadLine());
            int volume = lenth * wide * hight;
            double volumeInLithers = volume * 0.001;
            double numberPersent = persent * 0.01;
            double freeSpace = volumeInLithers * (1 - numberPersent);
            Console.WriteLine($"{freeSpace:F3}");

        }
    }
}
