using System;
using System.Collections.Generic;

namespace _501.Crosroads
{
    class Program
    {
        static void Main(string[] args)
        {

            int greenLight = int.Parse(Console.ReadLine());
            int freeWindow = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            Queue<string> cars = new Queue<string>();
            string car = null;
            int count = 0;

            while (input != "END")
            {
                if (input == "green")
                {
                    int green = greenLight;
                    while (green > 0)
                    {
                        if (cars.Count > 0)
                        {
                            car = cars.Dequeue();
                            green -= car.Length;
                            count++;
                        }
                        else if (green > 0)
                        {
                            green = 0;
                        }
                    }

                    int pass = freeWindow + green;

                    if (pass < 0)
                    {
                        int index = car.Length - Math.Abs(pass);
                        char hitIn = car[index];
                        Console.WriteLine("A crash happened!");
                        Console.WriteLine($"{car} was hit at {hitIn}.");
                        return;
                    }

                }
                else
                {
                    cars.Enqueue(input);
                }

                input = Console.ReadLine();
            }
            Console.WriteLine("Everyone is safe.");
            Console.WriteLine($"{count} total cars passed the crossroads.");
        }
    }
}
