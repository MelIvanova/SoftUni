using System;

namespace _02._Sum_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            string incom = Console.ReadLine();
            int result =0;

            for (int i = 0; i < incom.Length; i++)
            {
                int num = int.Parse(incom[i].ToString());
                result += num;
            }
            Console.WriteLine(result);
        }
    }
}
