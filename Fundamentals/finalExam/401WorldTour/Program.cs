using System;
using System.Linq;

namespace _401WorldTour
{
    class Program
    {
        static void Main(string[] args)
        {
            string stops = Console.ReadLine();
            string input = Console.ReadLine();

            while (input != "Travel")
            {
                string[] arguments = input.Split(':', StringSplitOptions.RemoveEmptyEntries);
                string command = arguments[0];

                switch (command)
                {
                    case "Add Stop":
                        int insertIndex = int.Parse(arguments[1]);
                        string adding = arguments[2];
                        if (insertIndex>=0 && insertIndex<stops.Length)
                        {
                            stops = stops.Insert(insertIndex, adding);
                        }
                        Console.WriteLine(stops);
                        break;
                    case "Remove Stop":
                        int start = int.Parse(arguments[1]);
                        int end = int.Parse(arguments[2]);
                        int length = (end + 1) - start;
                        if (start>=0 && start<stops.Length && end >=0 && end< stops.Length)
                        {
                            stops = stops.Remove(start, length);
                        }
                        Console.WriteLine(stops);
                        break;
                    case "Switch":
                        string substring = arguments[1];
                        string replace = arguments[2];
                        if (stops.Contains(substring))
                        {
                            stops = stops.Replace(substring, replace);
                        }
                        Console.WriteLine(stops);
                        break;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Ready for world tour! Planned stops: {stops}");
        }
    }
}
