using System;
using System.ComponentModel;
using System.Runtime;

namespace _03._Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int numOne = int.Parse(Console.ReadLine());
            int numTow = int.Parse(Console.ReadLine());
            
            switch (command)
            {
                case"add":
                    Add(numOne, numTow);
                    break;
                case "multiply":
                    Multiplay(numOne, numTow);
                    break;
                case "subtract":
                    Subtract(numOne, numTow);
                    break;
                case "divide":
                    Divide(numOne, numTow);
                    break;
            }
        }
 
        static void Add(int a, int b)
        {
            Console.WriteLine(a+b);
        }

        static void Multiplay(int a, int b)
        {
            Console.WriteLine(a*b);
        }

        static void Subtract(int a, int b)
        {
            Console.WriteLine(a-b);
        }

        static void Divide(int a, int b)
        {
            Console.WriteLine(a/b);
        }
    }
}
