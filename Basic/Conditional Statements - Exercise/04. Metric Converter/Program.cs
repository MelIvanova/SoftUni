using System;

namespace _04._Metric_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            string inputMetrical = Console.ReadLine();
            string outputMetrical = Console.ReadLine();

            if(inputMetrical == "mm" && outputMetrical == "m")
            {
                number = number / 1000;
            }
            else if (inputMetrical == "m" && outputMetrical == "mm")
            {
                number = number * 1000;
            }
            else if (inputMetrical == "cm" && outputMetrical == "m")
            {
                number = number / 100;

            }
           else if (inputMetrical == "mm" && outputMetrical == "cm")
            {
                number = number / 10;
            }
            else if (inputMetrical == "m" && outputMetrical == "cm")
            {
                number = number * 100;
            }
            else if (inputMetrical == "cm" && outputMetrical == "mm")
            {
                number = number * 10;

            }
            Console.WriteLine($"{number:F3}");
        }
    }
}
