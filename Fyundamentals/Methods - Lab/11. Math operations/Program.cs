using System;

namespace _11._Math_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            char operation = char.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            decimal result = Calculate(firstNum, operation, secondNum);
            Console.WriteLine($"{result}");
        }

        static decimal Calculate(int num1, char operations, int num2)
        {
            decimal result = 0;
            switch (operations)
            {
                case '-':
                    result = num1 - num2;
                    break;
                case '+':
                    result = num1 + num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    result = num1 / num2;
                    break;
            }
            return result;
        }
    }
}
