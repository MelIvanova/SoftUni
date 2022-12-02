using System;

namespace _2DRectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            
            double lenth = Math.Abs(x1 - x2);
            double width = Math.Abs(y1 - y2);
            double area = lenth * width;
            
            double perimeter = 2 * (lenth + width);
           
            Console.WriteLine($"{area:F2}");
            Console.WriteLine($"{perimeter:F2}");
        }
    }
}
