using System;

namespace LinkedLists
{
    class Program
    {
        static void Main(string[] args)
        {
            Node first = new Node(5);
            DounleLinkedList list = new DounleLinkedList();
            list.AddFitst(first);

            for (int i = 10; i < 50; i+=5)
            {
                list.AddFitst(new Node(i));
            }

            for (int i = 0; i < 10; i++)
            {
                list.AddLast(new Node(i));
            }

            list.ForEach(x => Console.WriteLine(x.Value));

            list.RemoveFirst();
            list.RemoveFirst();
            list.RemoveFirst();

            list.RemoveTail();
            list.RemoveTail();
            list.RemoveTail();
            list.RemoveTail();
            list.RemoveTail();

            //list.ForEach(x => Console.WriteLine(x.Value));

            

            Console.WriteLine(String.Join (" ",list.ToArray()));
        }
    }
}
