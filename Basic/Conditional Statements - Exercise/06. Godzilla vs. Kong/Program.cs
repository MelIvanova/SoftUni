using System;

namespace _06._Godzilla_vs._Kong
{
    class Program
    {
        static void Main(string[] args)
        {
            double buget = double.Parse(Console.ReadLine());
            int statists = int.Parse(Console.ReadLine());
            double clouthesPrice = double.Parse(Console.ReadLine());
            double decor = buget * 0.1;
            double totalClouthsPrice = clouthesPrice * statists;
            if (statists >150)
            {
                totalClouthsPrice = totalClouthsPrice - totalClouthsPrice * 0.1;
            }
            double filmTotalPrice = decor + totalClouthsPrice;
            double left = buget - filmTotalPrice;
            double need = filmTotalPrice - buget;
            if (buget < filmTotalPrice)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {need:F2} leva more.");
            }
            else if (buget >= filmTotalPrice)
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {left:F2} leva left.");
            }
        }
    }
}
