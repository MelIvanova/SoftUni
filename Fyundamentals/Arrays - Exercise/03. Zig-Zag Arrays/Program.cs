using System;
using System.Linq;

namespace _03._Zig_Zag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            string[] first = new string[count];
            string[] second = new string[count];
            for (int i = 0; i < count; i++)
            {
                string[] currentArray = Console.ReadLine().Split();
                if (i%2==0)
                {
                    first[i] = currentArray[1];
                    second[i] = currentArray[0];
                }
                else
                {
                    first[i] = currentArray[0];
                    second[i] = currentArray[1];
                }
            }
            Console.WriteLine(string.Join(" ", second));
            Console.WriteLine(string.Join(" ", first));
            
        }
    }
}
