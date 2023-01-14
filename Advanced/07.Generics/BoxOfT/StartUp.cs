using System;

namespace BoxOfT
{
   public class StartUp
    {
        static void Main(string[] args)
        {
            Box<int> box = new Box<int>();
            box.Add(1);
            box.Add(2);
            box.Add(3);
            Console.WriteLine(box.Remove());
            box.Add(4);
            box.Add(5);
            Console.WriteLine(box.Remove());

            Box<string> stringBox = new Box<string>();
            stringBox.Add("first");
            stringBox.Add("second");
            stringBox.Add("third");
            Console.WriteLine(stringBox.Remove());
            Console.WriteLine(stringBox.Count);


        }
    }
}
