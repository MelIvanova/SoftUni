using System;

namespace ZooShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int dogs = int.Parse(Console.ReadLine());
            int animals = int.Parse(Console.ReadLine());
            double money = dogs * 2.5 + animals * 4.0;
            Console.WriteLine($"{money:F2} lv.");
        }
    }
}
