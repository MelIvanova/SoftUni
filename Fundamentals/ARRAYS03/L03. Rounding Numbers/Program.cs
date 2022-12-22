using System;
using System.Linq;

namespace _03._Rounding_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] arrayOfNum = Console.ReadLine().Split().Select(double.Parse).ToArray();
            
            for (int i = 0; i < arrayOfNum.Length; i++)
            {
                if (arrayOfNum[i]==-0 || arrayOfNum[i]<0 && arrayOfNum[i]>-1)
                {
                    arrayOfNum[i] = 0;
                }
                Console.WriteLine($"{arrayOfNum[i]} => {Math.Round(arrayOfNum[i], MidpointRounding.AwayFromZero)}");

            }


        }
    }
}
