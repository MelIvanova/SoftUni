using System;

namespace _09._Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            switch (type)
            {
                case "int":
                    int num1 = int.Parse(Console.ReadLine());
                    int num2 = int.Parse(Console.ReadLine());
                    Number(num1, num2);
                    int result = Number(num1, num2);
                    Console.WriteLine(result);
                    break;
                case "char":
                    char character1 = char.Parse(Console.ReadLine());
                    char character2 = char.Parse(Console.ReadLine());
                    Character(character1, character2);
                    char resultChar = Character(character1, character2);
                    Console.WriteLine(resultChar);
                    break;
                case "string":
                    string str1 = Console.ReadLine();
                    string str2 = Console.ReadLine();
                    Srting(str1, str2);
                    string returning = Srting(str1, str2);
                    Console.WriteLine(returning);
                    break;
            }
        }

         static string Srting(string str1, string str2)
        {
            string returning = "";
            if (str1.CompareTo(str2)>=0)
            {
                returning = str1;
            }
            else
            {
                returning = str2;
            }
            return returning;
        }

        static char Character(char character1, char character2)
        {
            char resultChar = ' ';
            if (character1>character2)
            {
                resultChar = character1;
            }
            else
            {
                resultChar = character2;
            }
            return resultChar;
        }

        static int Number(int num1, int num2)
        {
            int result = 0;
            if (num1>num2)
            {
                result = num1;
            }
            else
            {
                result = num2;
            }
            return result;
        }
    }
}
