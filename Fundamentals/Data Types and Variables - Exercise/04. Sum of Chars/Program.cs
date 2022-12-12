using System;

namespace _04._Sum_of_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            int incomesNumber = int.Parse(Console.ReadLine());
            int totalSum = 0;
            for (int i = 1; i <= incomesNumber; i++)
            {
                char letter = char.Parse(Console.ReadLine());
              
                totalSum = totalSum + letter;
            }
            Console.WriteLine($"The sum equals: {totalSum}");
        }
    }
}
