using System;

namespace _06._Replace_Repeating_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            string charsArray = Console.ReadLine();
            int count = 0;
            string result = string.Empty;
            for (int i = 0; i < charsArray.Length; i++)

            {
                if (i<charsArray.Length-1)
                {

                    if (charsArray[i] == charsArray[i + 1])
                    {
                        count++;
                    }
                    else if (count != 0)
                    {
                        result += charsArray[i];
                        count = 0;
                    }
                    else
                    {
                        result += charsArray[i];
                    }
                }
                else
                {
                   
                    result += charsArray[i];
                   
                }
            }

            Console.WriteLine(result);
        }
    }
}
