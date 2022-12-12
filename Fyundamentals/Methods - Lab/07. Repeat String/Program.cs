using System;

namespace _07._Repeat_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            string result = RepeadString(str, count);
            Console.WriteLine(result);
        }

         static string RepeadString(string str, int count)
        {
            string  result = "";
            for (int i = 0; i < count; i++)
            {
                result+=str;

            }
            return result;
        }
    }
}
