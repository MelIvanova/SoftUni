using System;

namespace _03._Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int nuber = 0;
            string comand = Console.ReadLine();
            int sum = 0;
            while (comand!= "Stop")
            {
                nuber = int.Parse(comand);
                comand = Console.ReadLine();
                sum += nuber;
            }
            Console.WriteLine(sum);
        }
    }
}
