using System;
using System.Collections.Generic;


namespace L10._Crossroads
{
    class Program
    {
        static void Main(string[] args)
        {
            int greenight = int.Parse(Console.ReadLine());
            int freeWindow = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            Queue<string> cars = new Queue<string>();
            Queue<char> car = new Queue<char>();
            int count = 0;

            while (input != "END")
            {
                if (input == "green")
                {
                    int green = greenight;
                    string current = "";
                    while (green > 0)
                    {
                        if (car.Count == 0 && cars.Count > 0)
                        {
                            current = cars.Dequeue();
                            count++;
                            for (int i = 0; i < current.Length; i++)
                            {
                                car.Enqueue(current[i]);
                            }
                        }
                        else if (car.Count > 0)
                        {
                            car.Dequeue();
                            green--;
                        }
                        else
                        {
                            green = 0;
                        }
                    }

                    int pass = freeWindow;

                    while (pass > 0)
                    {
                        if (car.Count > 0)
                        {
                            car.Dequeue();
                            pass--;
                        }
                        else
                        {
                            break;
                        }
                    }

                    if (car.Count > 0)
                    {
                        Console.WriteLine("A crash happened!");
                        Console.WriteLine($"{current} was hit at {car.Peek()}.");
                        break;
                    }

                }
                else
                {
                    cars.Enqueue(input);
                }

                input = Console.ReadLine();
            }

            if (car.Count == 0)
            {
                Console.WriteLine("Everyone is safe.");
                Console.WriteLine($"{count} total cars passed the crossroads.");
            }

        }
    }
}
