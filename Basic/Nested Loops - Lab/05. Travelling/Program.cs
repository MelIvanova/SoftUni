using System;

namespace _05._Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            string country = Console.ReadLine();
            double incomes = 0;
            double sum = 0;
            while (country!= "End")
            {
                double coast = double.Parse(Console.ReadLine());
                while (sum<=coast)
                {
                    incomes= double.Parse(Console.ReadLine());
                    sum += incomes;
                    if (sum>=coast)
                    {
                        Console.WriteLine($"Going to {country}!");
                        sum-=sum;
                        break;
                    }
                }
                country = Console.ReadLine();
                
            }
           
        }
    }
}
