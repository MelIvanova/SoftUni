using System;

namespace _03._Odd__Even_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double minOdd = double.MaxValue;
            double maxOdd = double.MinValue;
            double minEven = double.MaxValue;
            double maxEven = double.MinValue;
            double sumOdd = 0.00;
            double sumEven = 0.00;
            for (int i = 1; i <=n; i++)
            {
                double number = double.Parse(Console.ReadLine());
                if(i%2 != 0)
                {
                    sumOdd += number;

                    if (minOdd > number)
                    {
                        minOdd = number;
                    }
                    if (maxOdd < number)
                    {
                        maxOdd = number;
                    }
                }
                else
                {
                    sumEven += number;
                    if (minEven > number)
                    {
                        minEven = number;
                    }
                    if (maxEven < number)
                    {
                        maxEven = number;
                    }
                }
                

            }
            Console.WriteLine($"OddSum={sumOdd:F2},");
            if (minOdd == double.MaxValue)
            {
                Console.WriteLine("OddMin=No,");
            }
            else
            {
                Console.WriteLine($"OddMin={minOdd:F2},");
            }
            if (maxOdd == double.MinValue)
            {
                Console.WriteLine("OddMax=No,");
            }
            else
            {
                Console.WriteLine($"OddMax={maxOdd:F2},");
            }
            Console.WriteLine($"EvenSum={sumEven:F2},");
            if (minEven == double.MaxValue)
            {
                Console.WriteLine("EvenMin=No,");
            }
            else
            {
                Console.WriteLine($"EvenMin={minEven:F2},");
            }
            if (maxEven == double.MinValue)
            {
                Console.WriteLine("EvenMax=No");
            }
            else
            {
                Console.WriteLine($"EvenMax={maxEven:F2}");
            }
        }
    }
}
