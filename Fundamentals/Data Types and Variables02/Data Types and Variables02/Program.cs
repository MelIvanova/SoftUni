using System;

namespace Data_Types_and_Variables02
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int addNumber = int.Parse(Console.ReadLine());
            int divideNumber = int.Parse(Console.ReadLine());
            int multiplyNumber = int.Parse(Console.ReadLine());
            firstNumber += addNumber;
            double result = (firstNumber / divideNumber);
            double printNum = Math.Floor(result) * multiplyNumber;
            Console.WriteLine(printNum);

        }
    }
}
