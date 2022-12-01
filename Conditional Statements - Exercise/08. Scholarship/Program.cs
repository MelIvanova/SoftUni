using System;

namespace _08._Scholarship
{
    class Program
    {
        static void Main(string[] args)
        {
            double input = double.Parse(Console.ReadLine());
            double averageDegree = double.Parse(Console.ReadLine());
            double minimalSalary = double.Parse(Console.ReadLine());
            
            double socialScilarship = minimalSalary * 0.35;
            
            double degreeScolarship = averageDegree * 25;
            
            if (input > minimalSalary && averageDegree < 5.50)
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
            else if (input < minimalSalary && averageDegree < 4.50)
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
            else if (input < minimalSalary && averageDegree > 4.50 && averageDegree < 5.50)
            {
                Console.WriteLine($"You get a Social scholarship {Math.Floor(socialScilarship)} BGN");
            }
            else if (input < minimalSalary && averageDegree >= 5.50)
            {
                if (socialScilarship < degreeScolarship)
                {
                    Console.WriteLine($"You get a scholarship for excellent results {Math.Floor(degreeScolarship)} BGN");
                }
                if (socialScilarship > degreeScolarship)
                {
                    Console.WriteLine($"You get a Social scholarship {Math.Floor(socialScilarship)} BGN");
                }
                if (socialScilarship == degreeScolarship)
                {
                    Console.WriteLine($"You get a scholarship for excellent results {Math.Floor(degreeScolarship)} BGN");
                }
            }
           else if (averageDegree >= 5.50)
            {
                Console.WriteLine($"You get a scholarship for excellent results {Math.Floor(degreeScolarship)} BGN");
            }



        }
    }
}
