using System;
using System.Text;

namespace _601._Computer_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double totoalPrice = 0;

            while (input!= "special" && input!= "regular")
            {
                double price = double.Parse(input);
                if (price<0)
                {
                    Console.WriteLine("Invalid price!");
                    input = Console.ReadLine();
                    continue;
                }
                else
                {
                    totoalPrice += price;
                }
                input = Console.ReadLine();
            }

            if (totoalPrice == 0)
            {
                Console.WriteLine("Invalid order!");
                return;
            }

            double taxes = totoalPrice * 0.2;
            double total = totoalPrice + taxes;
            if (input== "special")
            {
                total -= total * 0.1;
            }
            StringBuilder print = new StringBuilder();
            print.AppendLine("Congratulations you've just bought a new computer!");
            print.AppendLine($"Price without taxes: {totoalPrice:F2}$");
            print.AppendLine($"Taxes: {taxes:F2}$");
            print.AppendLine("-----------");
            print.AppendLine($"Total price: {total:F2}$");
            Console.WriteLine(print.ToString());
        }
    }
}
