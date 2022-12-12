using System;

namespace Text_Processing___Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] userNames = Console.ReadLine().Split(", ");
            string userName = "";
            bool invalid = true;
            for (int i = 0; i < userNames.Length; i++)
            {

                invalid = true;
                string name = userNames[i];
                if (name.Length > 3 && name.Length < 17 && invalid)
                {
                    
                    foreach (char symbol in name)
                    {
                        if (char.IsLetterOrDigit(symbol) || symbol=='-'|| symbol== '_' )
                        {
                            userName += symbol;
                        }
                        else
                        {
                            invalid = false;
                            break;
                        }
                    }
                    if (invalid)
                    {
                        Console.WriteLine(userName);
                        userName = "";
                    }
                }

            }
        }
    }
}
