using System;
using System.Linq;

namespace _05._Top_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            bool isBigger = true;
            for (int i = 0; i < numbers.Length-1; i++)
            {
                for (int j = 0; j < numbers.Length - 1-i && isBigger == true; j++)
                {
                    
                    if (numbers[i]>numbers[numbers.Length-1-j])
                    {   
                            isBigger = true;
                    }
                    else
                    {
                        isBigger = false;
                        break;
                    }

                }
                if (isBigger)
                {
                    Console.Write(numbers[i]+" ");
                }
                isBigger = true;
            }
            Console.Write(numbers[numbers.Length-1]);
        }
    }
}
