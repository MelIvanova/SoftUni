using System;

namespace _02._Summer_Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            int buget = int.Parse(Console.ReadLine());
            double towel = double.Parse(Console.ReadLine());
            double discount = double.Parse(Console.ReadLine());
            double umbrela = (2.0 / 3.0) * towel;
            double flipFlops = umbrela * 0.75;
            double bag = (flipFlops + towel) / 3;
            double moneyNeed = (towel + umbrela + flipFlops + bag) - ((towel + umbrela + flipFlops + bag)*(discount / 100));
            double diff = buget - moneyNeed;
            if (buget>=moneyNeed)
            {
                Console.WriteLine($"Annie's sum is {moneyNeed:F2} lv. She has {diff:F2} lv. left.");
            }
            else
            {
                Console.WriteLine($"Annie's sum is {moneyNeed:F2} lv. She needs {Math.Abs(diff):F2} lv. more.");
            }
        }
    }
}
