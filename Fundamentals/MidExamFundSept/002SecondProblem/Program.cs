using System;
using System.Collections.Generic;
using System.Linq;

namespace _002SecondProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> series = Console.ReadLine().Split().ToList();
            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] arguments = input.Split();
                string command = arguments[0];

                switch (command)
                {
                    case "reverse":
                        int indexStart = int.Parse(arguments[2]);
                        int count = int.Parse(arguments[4]);
                        List<string> current = new List<string>();
                        for (int i = indexStart; i < count + indexStart; i++)
                        {
                            current.Add(series[i]);
                        }
                        current.Reverse();
                        int counting = 0;
                        for (int i = indexStart; i < count + indexStart; i++)
                        {
                            series[i] = current[counting];
                            counting++;
                        }
                        break;
                    case "sort":
                        int begining = int.Parse(arguments[2]);
                        int length = int.Parse(arguments[4]);
                        List<string> toSort = new List<string>();
                        for (int i = begining; i < length + begining; i++)
                        {
                            toSort.Add(series[i]);
                        }
                        toSort.Sort();
                        int num = 0;
                        for (int i = begining; i < length + begining; i++)
                        {
                            series[i] = toSort[num];
                            num++;
                        }
                        break;
                    case "remove":
                        int removeCout = int.Parse(arguments[1]);
                        series.RemoveRange(0, removeCout);
                        break;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ", series));
        }
    }
}
