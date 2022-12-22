using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace _05._Multiply_Big_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string bigNumber = Console.ReadLine().TrimStart(new char[] { '0' }); 
            int multiply = int.Parse(Console.ReadLine());

            if (bigNumber == "0" || multiply == 0 || bigNumber == null)
            {
                Console.WriteLine(0);
                return;
            }

            int currentResult = 0;
            int inMined = 0;
            int addNum = 0;
            StringBuilder result = new StringBuilder();
            for (int i = bigNumber.Length - 1; i >= 0; i--)
            {
                int cuttent = int.Parse(bigNumber[i].ToString());
                currentResult = cuttent * multiply + inMined;
                inMined = currentResult / 10;
                addNum = currentResult % 10;
                result.Append(addNum);
                if (inMined != 0 && i == 0)
                {
                    result.Append(inMined);
                }
            }

            string print = new string(result.ToString().Reverse().ToArray());

            Console.WriteLine(print);

        }
    }
}
