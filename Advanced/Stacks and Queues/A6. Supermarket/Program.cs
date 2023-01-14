using System;
using System.Collections.Generic;

namespace A6._Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            Queue<string> people = new Queue<string>();
            int count = 0;

            while (name.ToLower() != "end")
            {
                if (name.ToLower() == "paid")
                {
                    for (int i = 0; i < count; i++)
                    {
                        Console.WriteLine(people.Dequeue());
                    }
                    count = 0;
                }
                else
                {
                    people.Enqueue(name);
                    count++;
                }

                name = Console.ReadLine();
            }

            Console.WriteLine($"{count} people remaining.");
        }
    }
}
