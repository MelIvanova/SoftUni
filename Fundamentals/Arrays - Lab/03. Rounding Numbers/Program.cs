using System;
using System.Linq;

namespace _03._Rounding_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] text = input.Split();
            double[] arrNumbers = new double[text.Length];
            for (int i = 0; i < text.Length; i++)
            {
                arrNumbers[i] = double.Parse(text[i]);
                Console.WriteLine($"{arrNumbers[i]} => {Math.Round(arrNumbers[i], MidpointRounding.AwayFromZero)}");
                
            }
            

        }
    }
}
