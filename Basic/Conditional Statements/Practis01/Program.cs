using System;

namespace Practis01
{
    class Program
    {
        static void Main(string[] args)
        {
            double evaluation = double.Parse(Console.ReadLine());
             if (evaluation >= 5.50)
            {
                Console.WriteLine("Exellent!");
            }
            else
            {
                Console.WriteLine("Not good!");
            }
            Console.WriteLine("Bye");
        }
    }
}
