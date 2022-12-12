using System;
using System.Linq;

namespace _04._Reverse_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] values = input.Split();
            for (int i = values.Length - 1; i >= 0; i--)
            {

                Console.Write(values[i] + " ");

            }

        }   
    }
}
 