using System;
using System.Collections.Generic;
using System.Linq;

namespace E02._Knights_of_Honor
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> text = Console.ReadLine().Split().ToList();
            Action<string> addAndPrint = t => Console.WriteLine($"Sir {t}");
            text.ForEach(addAndPrint);
        }
    }
}
