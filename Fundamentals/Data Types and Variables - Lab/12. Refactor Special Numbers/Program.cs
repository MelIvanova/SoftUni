using System;

namespace _12._Refactor_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            
            bool isSpecialNum = false;
            for (int i = 1; i <= number; i++)
            {
                int sum = 0;
                int num = i;
                
                while (i > 0)
                {
                    sum += i % 10;
                    i = i / 10;
                }
                isSpecialNum = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine("{0} -> {1}", num, isSpecialNum);
                i = num;
            }

        }
    }
}
