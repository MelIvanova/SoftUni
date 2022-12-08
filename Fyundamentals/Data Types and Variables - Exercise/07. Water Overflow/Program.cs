using System;

namespace _07._Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int incomes = int.Parse(Console.ReadLine());
            int tankCapacity = 0;

            for (int i = 1; i <= incomes; i++)
            {
                int liters = int.Parse(Console.ReadLine());

                if (tankCapacity + liters > 255)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {

                    tankCapacity += liters;
                }



            }

            Console.WriteLine(tankCapacity);
        }
        }
    }

