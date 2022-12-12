using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05._Multiply_Big_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine().TrimStart(new char[] {'0'}); ;
            int numb = int.Parse(Console.ReadLine());

            if (num == "0" || numb == 0 || num == "")
            {
                Console.WriteLine(0);
                return;
            }

            int tempResult = 0;
            int inMined = 0;
            int remainder = 0;
            StringBuilder result = new StringBuilder();
            for (int i = num.Length-1; i >= 0; i--)
            {
                char r = num[i];
                string t = r.ToString();
                int tr = int.Parse(t);
                tempResult = tr * numb + inMined;
                inMined = tempResult / 10;
                remainder = tempResult % 10;
                result.Append(remainder);
                if (inMined!=0&&i==0)
                {
                    result.Append(inMined);
                }
            }
            List<char> resultChar = result.ToString().Reverse().ToList();
            Console.WriteLine(String.Join("",resultChar));
        }         
    }
}
