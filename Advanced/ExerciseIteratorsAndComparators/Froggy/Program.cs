using System;
using System.Linq;

namespace Froggy
{
    class Program
    {
        static void Main(string[] args)
        {
            Lake lake = new Lake(Console.ReadLine().Split(", ",
                StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList());
            Console.WriteLine(String.Join((", "), lake));
        }
    }
}
