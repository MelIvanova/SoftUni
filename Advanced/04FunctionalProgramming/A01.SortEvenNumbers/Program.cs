using System;
using System.Linq;

namespace A01.SortEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(", ").Select(n => int.Parse(n)).
                Where(n => n % 2 == 0).OrderBy(n => n).ToArray();
            Console.WriteLine(String.Join(", ", numbers));
        }   
    }
}
