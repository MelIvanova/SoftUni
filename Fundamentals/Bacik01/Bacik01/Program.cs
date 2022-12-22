using System;

namespace Bacik01
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            string itIs = "";

            if (age <= 2 && age > -1)
            {
                itIs = "baby";
            }
            else if (age <= 13)
            {
                itIs = "child";
            }
            else if (age <= 19)
            {
                itIs = "teenager";
            }
            else if (age <= 65)
            {
                itIs = "adult";
            }
            else
            {
                itIs = "elder";
            }

            Console.WriteLine(itIs);
        }
    }
}
