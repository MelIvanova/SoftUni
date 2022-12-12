using System;

namespace _03._Extract_File
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int doth = input.LastIndexOf('.');
            string extention = "";
            
            for (int i = doth+1; i < input.Length; i++)
            {
                extention += input[i];
            }
           
            input = input.Replace(extention,"");
            int index = input.LastIndexOf('\\');
            string name = "";
            for (int i = index + 1; i < input.Length-1; i++)
            {
                name += input[i];
            }

            Console.WriteLine($"File name: {name}");
            Console.WriteLine($"File extension: {extention}");
        }
    }
}
