using System;
using System.Linq;

namespace A03._Count_Uppercase_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] words = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .Where(w => char.IsUpper(w[0])).ToArray();
            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
