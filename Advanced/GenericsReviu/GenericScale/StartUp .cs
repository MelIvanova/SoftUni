using System;

namespace GenericScale
{
   public class StartUp
    {

        static void Main(string[] args)
        {
            EqualityScale<string> words = new EqualityScale<string>("Plovdiv", "Plovdiv");
            Console.WriteLine(words.AreEqual());

            EqualityScale<string> citys = new EqualityScale<string>("Plovdiv", "Sofia");
            Console.WriteLine(citys.AreEqual());

        }
    }
}
