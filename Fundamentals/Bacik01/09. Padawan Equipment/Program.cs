using System;

namespace _09._Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double buget = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double lightsabersPrice = double.Parse(Console.ReadLine());
            double robePrice = double.Parse(Console.ReadLine());
            double beltPrice = double.Parse(Console.ReadLine());
            double lightsabers = Math.Ceiling(students + (students * 0.1));
            double beltsFree = students / 6;
            double price = (lightsabers * lightsabersPrice) + 
                (students * robePrice) + 
                (beltPrice * (students  - Math.Floor(beltsFree)));
            if (buget >= price)
            {
                Console.WriteLine($"The money is enough - it would cost {price:F2}lv.");
            }
            else
            {
                double diff = price - buget;
                Console.WriteLine($"Ivan Cho will need {diff:F2}lv more.");
            }
        }
    }
}
