using System;

namespace _02._Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            Grades(num);
        }

        static void Grades(double n)
        {
            if ( 2.00 <= n && n<=2.99)
            {
                Console.WriteLine("Fail");
            }
            else if (3.00 <= n && n <= 3.49)
            {
                Console.WriteLine("Poor");
            }
            else if (3.50 <= n && n <= 4.49)
            {
                Console.WriteLine("Good");
            }
            else if (4.50 <= n && n <= 5.49)
            {
                Console.WriteLine("Very good");
            }
            else if (5.50 <= n && n <= 6.00)
            {
                Console.WriteLine("Excellent");
            }
        }
    }
}
