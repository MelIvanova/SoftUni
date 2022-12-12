using System;
using System.Linq;

namespace Text_Processing___Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();


            while (input != "end")
            {
                char[] temp = input.Reverse().ToArray(); 
                string reverce = String.Join("", temp);
                Console.WriteLine($"{input} = {reverce}");
                input = Console.ReadLine();
            }
        }
    }
}
