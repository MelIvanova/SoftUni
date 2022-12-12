using System;

namespace _04._Password_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            bool lenth = PasswordLenthIsValid(password);
            bool charectersContains = IsPasswordOnliLettersNumbers(password);
            bool towNumbers = IsPasswordContainsTowNumbers(password);
            if (lenth && charectersContains&& towNumbers)
            {
                Console.WriteLine("Password is valid");
            }
            if (!lenth)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (!charectersContains)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (!towNumbers)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
        }

        static bool IsPasswordContainsTowNumbers(string password)
        {
            int count = 0;
            foreach (char i in password)
            {
                if (Char.IsDigit(i))
                {
                    count++;
                }
            }
            if (count >= 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool IsPasswordOnliLettersNumbers(string password)
        {
            foreach (char i in password)
            {
                if (!Char.IsLetterOrDigit(i))
                {
                    return false;
                }   
            }
            return true;
        }

        static bool PasswordLenthIsValid(string password)
        {
            int counter = 0;
            for (int i = 0; i < password.Length; i++)
            {
                counter++;
            }
            if (counter>=6 && counter<=10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
