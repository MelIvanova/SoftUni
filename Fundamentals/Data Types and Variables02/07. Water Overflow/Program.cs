using System;

namespace _07._Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int capacity = 255;
            int lines = int.Parse(Console.ReadLine());
            int litersPour = 0;

            for (int i = 0; i < lines; i++)
            {
                int pourIn = int.Parse(Console.ReadLine());

                if(capacity>= pourIn)
                {
                    capacity -= pourIn;
                    litersPour += pourIn;
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }
            }

            Console.WriteLine(litersPour);
        }
    }
}
