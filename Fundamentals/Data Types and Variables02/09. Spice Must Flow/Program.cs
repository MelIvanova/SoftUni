using System;

namespace _09._Spice_Must_Flow
{
    class Program
    {
        static void Main(string[] args)
        {
            int spice = int.Parse(Console.ReadLine());
            bool end = true;
            int extract = 0;
            int days = 0;

            if (spice<100)
            {
                end = false;
            }

            while (end)
            {
                if (spice>=100)
                {
                    extract += spice;
                    days++;
                    spice -= 10;
                    extract -= 26;
                }
                else
                {
                    extract -= 26;
                    end = false;
                }
            }

            Console.WriteLine(days);
            Console.WriteLine(extract);
        }
    }
}
