using System;

namespace _06._Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int wide = int.Parse(Console.ReadLine());
            int hight = int.Parse(Console.ReadLine());
            int cake = wide * hight;
            string command = Console.ReadLine();
            int peases = 0;
            
            while (command!="STOP")
            {
                peases = int.Parse(command);
                cake -= peases;
                if (cake==0)
                {
                    Console.WriteLine($"{cake} pieces are left.");
                    break;
                }
                else if (cake<0)
                {
                    Console.WriteLine($"No more cake left! You need {Math.Abs(cake)} pieces more.");
                    break;
                }
                command = Console.ReadLine();
            }
            if (command == "STOP")
            {
                Console.WriteLine($"{cake} pieces are left.");
            }
           
        }
    }
}
