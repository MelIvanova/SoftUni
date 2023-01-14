using System;

namespace _05._Character_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int lenth = name.Length;
            for (int i = 0; i < lenth; i++)
            {
                Console.WriteLine(name[i]);
            }
        }
    }
}
