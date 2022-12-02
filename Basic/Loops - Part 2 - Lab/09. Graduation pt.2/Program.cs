using System;

namespace _09._Graduation_pt._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int i = 1;
            double sum = 0, gread = 0, final = 0, bad=0;
            while (i<=12)
            {
                gread = double.Parse(Console.ReadLine());
                if (gread>=4)
                {
                    sum += gread;
                    final = sum / i;
                    i++;
                }
                else
                {
                    bad += 1;
                    if (bad==2)
                    {
                        Console.WriteLine($"{name} has been excluded at {i} grade");
                        return;
                    }
                    i = i + 0;
                }
            }
            Console.WriteLine($"{name} graduated. Average grade: {final:F2}");
        }
    }
}
