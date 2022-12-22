using System;

namespace _10._Top_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            TopNumber(number);
        }

        private static void TopNumber(int number)
        {
            for (int i = 17; i <= number; i++)
            {
                int sum = 0;
                bool haveOdd = false;
                int check = i;

                while (check!=0)
                {
                    int num = check % 10;
                    if (num%2!=0)
                    {
                        haveOdd = true;
                    }
                    sum += num;
                    check = check / 10;
                }

                if (sum%8==0 && haveOdd)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
