using System;

namespace M01._Sort_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numA = int.Parse(Console.ReadLine());
            int numB = int.Parse(Console.ReadLine());
            int numC = int.Parse(Console.ReadLine());

            if(numA > numB && numA > numC)
            {
                Console.WriteLine(numA);
                if(numB >= numC)
                {
                    Console.WriteLine(numB);
                    Console.WriteLine(numC);
                }
                else if(numC >= numB)
                {
                    Console.WriteLine(numC);
                    Console.WriteLine(numB);
                }
            }
            if (numB > numA && numB > numC)
            {
                Console.WriteLine(numB);
                if (numA >= numC)
                {
                    Console.WriteLine(numA);
                    Console.WriteLine(numC);
                }
                else if (numC >= numA)
                {
                    Console.WriteLine(numC);
                    Console.WriteLine(numA);
                }
                
            }
            if (numC > numB && numC > numA)
            {
                Console.WriteLine(numC);
                if (numB >= numA)
                {
                    Console.WriteLine(numB);
                    Console.WriteLine(numA);
                }
                else if (numA >= numB)
                {
                    Console.WriteLine(numA);
                    Console.WriteLine(numB);
                }
            }
        }
    }
}
