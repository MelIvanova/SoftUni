using System;
using System.Collections.Generic;
using System.Linq;

namespace E07._Predicate_For_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenhth = int.Parse(Console.ReadLine());
            //List<string> names = Console.ReadLine().Split().Where(n=>n.Length <= length).ToList();
            List<string> names = Console.ReadLine().Split().ToList();
            Func<List<string>, List<string>> rightLength = n =>
            {
                List<string> corect = new List<string>();

                for (int i = 0; i < names.Count; i++)
                {
                    if (names[i].Length <= lenhth)
                    {
                        corect.Add(names[i]);
                    }
                }

                return corect;
            };

            Console.WriteLine(String.Join(Environment.NewLine, rightLength(names)));
        }
    }
}
