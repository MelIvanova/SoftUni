using System;

namespace _01._Savings
{
    class Program
    {
        static void Main(string[] args)
        {
            double income = double.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            double expence = double.Parse(Console.ReadLine());
            double emergency = income * 0.30;
            double saving = (income - (expence + emergency)) * month;
            double percent = saving / (income * month) * 100;
            Console.WriteLine($"She can save {percent:F2}%");
            Console.WriteLine($"{saving:F2}");

        }
    }
}
