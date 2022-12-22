using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Append_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] splititng = Console.ReadLine().Split('|').ToArray();
            List<string> appended = new List<string>();
            for (int i = splititng.Length - 1; i >= 0; i--)
            {
                string[] numbers = splititng[i].Split(" ",StringSplitOptions.RemoveEmptyEntries);
                appended.AddRange(numbers);
            }

            Console.WriteLine(string.Join(' ', appended));
        }
    }
}
