using System;

namespace _15.DebugSubstring
{
    class Program
    {
        static void Main(string[] args)
        {

            {
                string text = Console.ReadLine();
                int jump = int.Parse(Console.ReadLine());
                int num = 112;
                char c = Convert.ToChar(num);

                bool hasMatch = false;

                for (int i = 0; i < text.Length; i++)
                {
                    if (text[i] == c)
                    {
                        hasMatch = true;                 
                        string match = "";
                        if (jump>(text.Length-1-i))
                        {
                            jump = (text.Length - 1 - i);
                        }
                        for (int im = i; im <= (jump+i); im++)
                        {
                            match += text[im];
                        }
                        Console.WriteLine(match);
                        i += jump;
                    }
                }

                if (!hasMatch)
                {
                    Console.WriteLine("no");
                }
            }
        }
    }
}
