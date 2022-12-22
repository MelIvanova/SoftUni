using System;

namespace _06._Strong_number
{
    class Program
    {
        static void Main(string[] args)
        {
            string incom = Console.ReadLine();
            int result = 0;

            for (int i = 0; i < incom.Length; i++)
            {
                int number = int.Parse(incom[i].ToString());
                int multiply = number;
                for (int m = number-1; m > 1; m--)
                {
                   
                    multiply *= m; 
                    
                }
                result += multiply;
            }
            int check = int.Parse(incom);
            if(result == check)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
