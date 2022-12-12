using System;

namespace _03._Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string serch = Console.ReadLine().ToLower();
            string serchIn = Console.ReadLine().ToLower();
            for (int i = 0; i < serchIn.Length; i++)
            {
                if (serchIn.Contains(serch))
                {
                    serchIn = serchIn.Remove(serchIn.IndexOf(serch), serch.Length);
                }
            }

            Console.WriteLine(serchIn);
        }
    }
}
