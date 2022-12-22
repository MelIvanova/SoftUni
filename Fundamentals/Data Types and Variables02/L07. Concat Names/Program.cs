using System;
using System.Collections.Specialized;

namespace L07._Concat_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string secondName = Console.ReadLine();
            string delimiter = Console.ReadLine();

            Console.Write($"{firstName}{delimiter}{secondName}");
        }
    }
}
