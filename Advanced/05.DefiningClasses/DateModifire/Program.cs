using System;

namespace DateModifire
{
   public class Program
    {
        static void Main(string[] args)
        {
            string fitst = Console.ReadLine();
            string second = Console.ReadLine();
            int days = DateModifire.DateDifrenceBetwinDates(fitst, second);

            Console.WriteLine(days);
        }
    }
}
