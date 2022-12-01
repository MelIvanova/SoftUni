using System;

namespace TailoringWorkshop
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberTables = int.Parse(Console.ReadLine());
            double lenthTable = double.Parse(Console.ReadLine());
            double wideTable = double.Parse(Console.ReadLine());

            double lenthCare = lenthTable  / 2;
            double care = lenthCare * lenthCare;
            double tablecloth = (lenthTable +2*0.3) * (wideTable +2*0.3);

            double tableclothPrice = tablecloth * numberTables * 7;
            double carePrice = care * numberTables * 9;

            Console.WriteLine($"{tableclothPrice + carePrice:F2} USD");
            Console.WriteLine($"{tableclothPrice*1.85 + carePrice*1.85:F2} BGN");



        }
    }
}
