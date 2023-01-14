using System;
using System.Linq;
using System.Collections.Generic;

namespace E01._Action_Print
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split().ToList();
            Action<String> print = (x) => Console.WriteLine(x);
            names.ForEach(print);
        }
   
    }
}
