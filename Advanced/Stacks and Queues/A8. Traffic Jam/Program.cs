using System;
using System.Collections.Generic;

namespace A8._Traffic_Jam
{
    class Program
    {
        static void Main(string[] args)
        {
            int carsPasses = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            Queue<string> trafficJam = new Queue<string>();
            int count = 0;

            while (input.ToLower() != "end")
            {
                if (input.ToLower() == "green")
                {
                    for (int i = 0; i < carsPasses; i++)
                    {
                        if (trafficJam.Count > 0)
                        {
                            count++;
                            Console.WriteLine($"{trafficJam.Dequeue()} passed!");
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                else
                {
                    trafficJam.Enqueue(input);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"{count} cars passed the crossroads.");
        }
    }
}
