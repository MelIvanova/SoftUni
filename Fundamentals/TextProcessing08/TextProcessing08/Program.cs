using System;

namespace TextProcessing08
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] userNames = Console.ReadLine().Split(", ");
            

            for (int i = 0; i < userNames.Length; i++)
            {
                bool validUser = false;
                string name = userNames[i];

                if (name.Length >= 3 && name.Length <= 16)
                {

                    foreach (char symbol in name)
                    {
                        if (char.IsLetterOrDigit(symbol) || symbol == '-' || symbol == '_')
                        {
                            validUser = true;
                        }
                        else
                        {
                            validUser = false;
                            break;
                        }
                    }
                }
                if (validUser)
                {
                    Console.WriteLine(name);
                }
            }
        }
    }
}
