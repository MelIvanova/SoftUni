using System;

namespace _01._Number_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int counter = 1;
            bool isBogger = false;
            for (int rows = 1; rows <= n; rows++)
            {
                for (int colons = 1; colons <= rows; colons++)
                {
                    if (counter >n)
                    {
                        isBogger = true;
                        break;
                    }
                    Console.Write(counter + " ");
                    counter++;
                }
                if (isBogger)
                {
                    break;
                }
                Console.WriteLine();
            }
        }
    }
}
