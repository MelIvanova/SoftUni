using System;

namespace _02._Equal_Sums_Even_Odd_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            int firsNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            for (int i = firsNum; i <= secondNum; i++)
            {
                string currentNum = i.ToString();
                int odd = 0;
                int even = 0;
                for (int m = 0; m < currentNum.Length; m++)
                {
                    int numbers = int.Parse(currentNum[m].ToString());
                    if (m%2 == 0)
                    {
                        even += numbers;
                    }
                    else 
                    {
                        odd += numbers;
                    }

                }
                if (even==odd)
                {
                    Console.Write(i + " ");
                }
            }




        }
    }
}
