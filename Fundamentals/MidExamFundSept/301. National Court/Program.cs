using System;

namespace _301._National_Court
{
    class Program
    {
        static void Main(string[] args)
        {
            int employeOneCapacity = int.Parse(Console.ReadLine());
            int employeTwoCapacity = int.Parse(Console.ReadLine());
            int employeThreeCapacity = int.Parse(Console.ReadLine());
            int peoplePass = employeOneCapacity + employeTwoCapacity + employeThreeCapacity;
            int peple = int.Parse(Console.ReadLine());
            int howers = 0;
            

            while (peple > 0)
            {
                peple -= peoplePass;
                howers++;

                if (howers%4==0)
                {
                    howers++;
                }
            }

           

            Console.WriteLine($"Time needed: {howers}h.");

        }
    }
}
