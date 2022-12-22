using System;
using System.Linq;
using System.Security.Authentication;

namespace _11._Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] income = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string command = string.Empty;

            while ((command = Console.ReadLine()) != "end")
            {
                if (command[0] == 'e' && command[1] == 'x')
                {
                    int[] change = Exchange(income, command);
                    income = change;
                }
                else if (command[0] == 'l' &&
                    (command[command.Length - 1] == 'd' || command[command.Length - 1] == 'n'))
                {
                    LastNumOddOrEven(income, command);
                }
                else if (command[0] == 'f' &&
                    (command[command.Length - 1] == 'd' || command[command.Length - 1] == 'n'))
                {
                    FirstNumOddOrEven(income, command);
                }
                else if (command[1] == 'a' && 
                    (command[command.Length-1] == 'd' || command[command.Length - 1] == 'n'))
                {
                    IndexMaxOddOrEven(income, command);
                }
                else if (command[1] == 'i' && 
                    (command[command.Length - 1] == 'd' || command[command.Length - 1] == 'n'))
                {
                    IndexMinOddOrEven(income, command);
                }
                
     

            }

            Console.WriteLine($"[{string.Join(", ", income)}]");
        }

        private static void LastNumOddOrEven(int[] income, string command)
        {
            string num = string.Empty;

            for (int i = 5; i < command.Length; i++)
            {

                if (command[i] >= 48 && command[i] <= 57)
                {
                    num += command[i].ToString();
                }

            }

            int reqiredNums = int.Parse(num);
            int[] numbers = new int[reqiredNums];
            int count = 0;

            if (reqiredNums == 0)
            {
                Console.WriteLine("[]");
                return;
            }

            if (reqiredNums > income.Length)
            {
                Console.WriteLine("Invalid count");
            }
            else
            {
                if (command[7] == 'o')
                {
                    for (int i = income.Length - 1; i >= 0; i--)
                    {
                        if (income[i] % 2 != 0)
                        {
                            numbers[count] = income[i];
                            count++;
                        }
                        if (count == reqiredNums)
                        {
                            break;
                        }
                    }
                }
                else
                {
                    for (int i = income.Length - 1; i >= 0; i--)
                    {
                        if (income[i] % 2 == 0)
                        {
                            numbers[count] = income[i];
                            count++;
                        }
                        if (count == reqiredNums)
                        {
                            break;
                        }
                    }
                }
                
                 if (count < reqiredNums)
                {
                    int[] arr = new int[count];
                    for (int i = 0; i < count; i++)
                    {
                        arr[i] = numbers[i];
                    }
                    Console.WriteLine($"[{string.Join(", ", arr)}]");
                }
                else
                {
                    Console.WriteLine($"[{string.Join(", ", numbers)}]");
                }


            }
        }

        private static void FirstNumOddOrEven(int[] income, string command)
        {
            string num = string.Empty;

            for (int i = 6; i < command.Length; i++)
            {

                if (command[i] >= 48 && command[i] <= 57)
                {
                    num += command[i].ToString();
                }

            }

            int reqiredNums = int.Parse(num);
            int[] numbers = new int[reqiredNums];
            int count = 0;

            if (reqiredNums == 0)
            {
                Console.WriteLine("[]");
                return;
            }

            if (reqiredNums > income.Length)
            {
                Console.WriteLine("Invalid count");
            }
            else
            {
                if (command[8] == 'o')
                {
                    for (int i = 0; i < income.Length; i++)
                    {
                        if (income[i] % 2 != 0)
                        {
                            numbers[count] = income[i];
                            count++;
                        }
                        if (count == reqiredNums)
                        {
                            break;
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < income.Length; i++)
                    {
                        if (income[i] % 2 == 0)
                        {
                            numbers[count] = income[i];
                            count++;
                        }
                        if (count == reqiredNums)
                        {
                            break;
                        }
                    }
                }    
                if (count < reqiredNums)
                {
                    int[] arr = new int[count];
                    for (int i = 0; i < count; i++)
                    {
                        arr[i] = numbers[i];
                    }
                    Console.WriteLine($"[{string.Join(", ", arr)}]");
                }
                else
                {
                    Console.WriteLine($"[{string.Join(", ", numbers)}]");
                }


            }
        }

        private static void IndexMinOddOrEven(int[] income, string command)
        {
            int corectOdd = int.MaxValue;
            int corectEven = int.MaxValue;
            int indexMin = -1;
            bool notFound = true;

            if (command == "min odd")
            {
                for (int i = 0; i < income.Length; i++)
                {
                    if (income[i] % 2 != 0)
                    {
                        if (income[i] <= corectOdd)
                        {
                            corectOdd = income[i];
                            indexMin = i;
                            notFound = false;
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < income.Length; i++)
                {
                    if (income[i] % 2 == 0)
                    {
                        if (income[i] <= corectEven)
                        {
                            corectEven = income[i];
                            indexMin = i;
                            notFound = false;
                        }
                    }
                }
            }
            if (notFound)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine(indexMin);
            }
        }

        private static void IndexMaxOddOrEven(int[] income, string command)
        {
            int corectOdd = int.MinValue;
            int corectEven = int.MinValue;
            int indexMax = -1;
            bool notFound = true;

            if (command == "max odd")
            {
                for (int i = 0; i < income.Length; i++)
                {
                    if (income[i] % 2 != 0)
                    {
                        if (income[i] >= corectOdd)
                        {
                            corectOdd = income[i];
                            indexMax = i;
                            notFound = false;
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < income.Length; i++)
                {
                    if (income[i] % 2 == 0)
                    {
                        if (income[i] >= corectEven)
                        {
                            corectEven = income[i];
                            indexMax = i;
                            notFound = false;
                        }
                    }
                }
            }
            if (notFound)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine(indexMax);
            }

        }

        private static int[] Exchange(int[] income, string command)
        {

            string num = string.Empty;

            for (int i = 8; i < command.Length; i++)
            {

                if (command[i] >= 48 && command[i] <= 57)
                {
                    num += command[i].ToString();
                }

            }

            int index = int.Parse(num);
            int[] current = new int[income.Length];
            int count = 0;

            if (index <= income.Length - 1)
            {
                for (int i = index + 1; i < income.Length; i++)
                {
                    current[count] = income[i];
                    count++;
                }
                int countNow = count;
                for (int i = 0; i <= (income.Length - 1 - countNow); i++)
                {
                    current[count] = income[i];
                    count++;
                }
                income = current;
            }
            else
            {
                Console.WriteLine("Invalid index");
            }

            return income;
        }
    }
}
