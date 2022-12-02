using System;

namespace _09._Trade_Commissions
{
    class Program
    {
        static void Main(string[] args)
        {
            

            string city = Console.ReadLine();
            double voliumSales = double.Parse(Console.ReadLine());
            double comishon = 0;
            if(city == "Sofia")
            {
                if(voliumSales>=0 && voliumSales <=500)
                {
                    comishon = voliumSales * 0.05;
                }
                else if(voliumSales>500 && voliumSales<=1000)
                {
                    comishon = voliumSales * 0.07;
                }
                else if(voliumSales>1000 && voliumSales<=10000)
                {
                    comishon = voliumSales * 0.08;
                }
                else if (voliumSales>10000)
                {
                    comishon = voliumSales * 0.12;
                }
                else if (voliumSales <0)
                {
                    Console.WriteLine("error");
                }
                if(voliumSales>0)
                {
                    Console.WriteLine($"{comishon:F2}");
                }
            }
           else if (city == "Varna")
            {
                if (voliumSales >= 0 && voliumSales <= 500)
                {
                    comishon = voliumSales * 0.045;
                }
                else if (voliumSales > 500 && voliumSales <= 1000)
                {
                    comishon = voliumSales * 0.075;
                }
                else if (voliumSales > 1000 && voliumSales <= 10000)
                {
                    comishon = voliumSales * 0.10;
                }
                else if (voliumSales > 10000)
                {
                    comishon = voliumSales * 0.13;
                }
                else if (voliumSales < 0)
                {
                    Console.WriteLine("error");
                }
                if (voliumSales > 0)
                {
                    Console.WriteLine($"{comishon:F2}");
                }
            }
            else if (city == "Plovdiv")
            {
                if (voliumSales >= 0 && voliumSales <= 500)
                {
                    comishon = voliumSales * 0.055;
                }
                else if (voliumSales > 500 && voliumSales <= 1000)
                {
                    comishon = voliumSales * 0.08;
                }
                else if (voliumSales > 1000 && voliumSales <= 10000)
                {
                    comishon = voliumSales * 0.12;
                }
                else if (voliumSales > 10000)
                {
                    comishon = voliumSales * 0.145;
                }
                else if (voliumSales < 0)
                {
                    Console.WriteLine("error");
                }
                if (voliumSales > 0)
                {
                    Console.WriteLine($"{comishon:F2}");
                }
            }
            else
            {
                Console.WriteLine("error");
            }
            
           

        }
    }
}
