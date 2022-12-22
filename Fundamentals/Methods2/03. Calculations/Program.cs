using System;

namespace _03._Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            
            switch (command)
            {
                case "add":
                    AddNumbers(firstNum, secondNum);
                    break;
                case "multiply":
                    MultiplyNtbers(firstNum, secondNum);
                    break;
                case "subtract":
                    SubstractNumbers(firstNum, secondNum);
                    break;
                case "divide":
                    DivideNumbers(firstNum, secondNum);
                    break;
            }
        }

        private static void DivideNumbers(int firstNum, int secondNum)
        {
            double result = firstNum * 1.0 / secondNum;
            Console.WriteLine(result);
        }

        private static void SubstractNumbers(int firstNum, int secondNum)
        {
            int result = firstNum - secondNum;
            Console.WriteLine(result);
        }

        private static void MultiplyNtbers(int firstNum, int secondNum)
        {
            int result = firstNum * secondNum;
            Console.WriteLine(result);
        }

        private static void AddNumbers(int firstNum, int secondNum)
        {
            int result = firstNum + secondNum;
            Console.WriteLine(result);
        }
    }
}
