using System;
using System.Globalization;

namespace _02._Common_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fitrst = Console.ReadLine().Split();
            string[] second = Console.ReadLine().Split();

            for (int i = 0; i < second.Length; i++)
            {
                for (int j = 0; j < fitrst.Length; j++)
                {
                    if (second[i] == fitrst[j])
                    {
                        if (i < second.Length - 1)
                        {
                            Console.Write(second[i] + " ");
                        }
                        else
                        {
                            Console.Write(second[i]);
                        }
                        
                    }
                }
            }
        }
    }
}
