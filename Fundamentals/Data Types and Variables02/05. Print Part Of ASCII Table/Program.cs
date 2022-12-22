using System;

namespace _05._Print_Part_Of_ASCII_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            string print = "";

            for (int i = start; i <= end; i++)
            {
                char simbol = Convert.ToChar(i);
                if (i < end)
                {
                    print += simbol;
                    print += ' ';
                }
                else
                {
                    print += simbol;
                }
                
            }

            Console.WriteLine(print);
        }
    }
}
