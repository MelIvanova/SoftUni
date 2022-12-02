using System;

namespace _07._Operations_Between_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //o	"Cannot divide {N1} by zero"

            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            char operation = char.Parse(Console.ReadLine());

            switch(operation)
            {
                case '+':
                    int result = number1 + number2;
                    if(result%2 == 0)
                    {
                        Console.WriteLine($"{number1} {operation} {number2} = {result} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{number1} {operation} {number2} = {result} - odd");
                    }
                    break;
                case '-':
                    int result1 = number1 - number2;
                    if (result1 % 2 == 0)
                    {
                        Console.WriteLine($"{number1} {operation} {number2} = {result1} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{number1} {operation} {number2} = {result1} - odd");
                    }
                    break;
                case '*':
                    int result2 = number1 * number2;
                    if (result2 % 2 == 0)
                    {
                        Console.WriteLine($"{number1} {operation} {number2} = {result2} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{number1} {operation} {number2} = {result2} - odd");
                    }
                    break;
                case '/':

                    if(number2==0)
                    {
                        Console.WriteLine($"Cannot divide {number1} by zero");
                    }
                    else
                    {
                        double result3 = number1*1.0 / number2;
                        Console.WriteLine($"{number1} / {number2} = {result3:F2}");
                    }    
                    break;
                case '%':
                    if (number2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {number1} by zero");
                    }
                    else
                    {
                        int result4 = number1 % number2;
                        Console.WriteLine($"{number1} % {number2} = {result4}");
                    }
                    break;

            }

        }
    }
}
