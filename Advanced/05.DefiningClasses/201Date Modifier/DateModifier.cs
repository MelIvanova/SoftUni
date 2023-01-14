using System;
using System.Collections.Generic;
using System.Text;

amespace DateModifier
{
    class DateModifier
{
    static void Main(string[] args)
    {

        DateTime current = DateTime.Parse(Console.ReadLine());
        DateTime next = DateTime.Parse(Console.ReadLine());
        TimeSpan result = current - next;

        Console.WriteLine(Math.Abs(result.Days));
    }
}
}