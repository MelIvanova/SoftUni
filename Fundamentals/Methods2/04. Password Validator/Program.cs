using System;

namespace _04._Password_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            string pasword = Console.ReadLine();
           
            bool isValid = CharacterLength(pasword);
            bool rightCharacters = CharacterContainse(pasword);
            bool haveTwo = HaveTwoDigits(pasword);

            if (isValid && rightCharacters && haveTwo)
            {
                Console.WriteLine("Password is valid");
            }
        }

        private static bool HaveTwoDigits(string pasword)
        {
            bool areTwo = false;
            int count = 0;

            for (int i = 0; i < pasword.Length; i++)
            {
                if (pasword[i]>=48&&pasword[i]<=57)
                {
                    count++;
                    if (count==2)
                    {
                        areTwo = true;
                        break;
                    }
                }
            }
            if (areTwo==false)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
            return areTwo;
        }

        private static bool CharacterContainse(string pasword)
        {
            bool rightCharacters = false;

            for (int i = 0; i < pasword.Length; i++)
            {
                if (pasword[i] >= 48 && pasword[i] <= 57|| pasword[i] >= 65 && pasword[i] <= 90|| pasword[i] >= 97 && pasword[i] <= 122)
                {
                    rightCharacters = true;
                }
                else
                {
                    rightCharacters = false;
                    break;
                }
            }
            if (rightCharacters==false)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            return rightCharacters;
        }

        private static bool CharacterLength(string pasword)
        {
            bool isValid = false;

            if (pasword.Length < 6 || pasword.Length > 10)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            else
            {
                isValid = true;
            }
            return isValid;
        }
    }
}
