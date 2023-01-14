using System;

namespace IntDoubleString
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            switch (command)
            {
                case "integer":
                    int number = int.Parse(Console.ReadLine());
                    Console.WriteLine(number + 1);
                    break;
                case "real":
                    double realNum = double.Parse(Console.ReadLine());
                    realNum += 1;
                    Console.WriteLine($"{realNum :f2}");
                    break;
                case"text":
                    string text = Console.ReadLine();
                    Console.WriteLine($"{text}*");
                    break;
            }
        }
    }
}
