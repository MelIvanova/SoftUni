using System;
using System.Linq;

namespace _502._Array_Modifier
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] arguments = input.Split();
                string command = arguments[0];

                switch (command)
                {
                    case "swap":
                        int indexFirst = int.Parse(arguments[1]);
                        int indexSecond = int.Parse(arguments[2]);
                        int current = array[indexFirst];
                        array[indexFirst] = array[indexSecond];
                        array[indexSecond] = current;
                        break;
                    case "multiply":
                        int firstIndex = int.Parse(arguments[1]);
                        int secondIndex = int.Parse(arguments[2]);
                        int result = array[firstIndex] * array[secondIndex];
                        array[firstIndex] = result;
                        break;
                    case "decrease":
                        for (int i = 0; i < array.Length; i++)
                        {
                            array[i] -= 1;
                        }
                        break;
                }

                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ",array));
        }
    }
}
