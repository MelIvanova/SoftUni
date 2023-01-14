using System;
using System.Collections.Generic;
using System.Text;

namespace CustomTuple
{
   public class MyTupe<T1, T2>
    {
        public MyTupe(T1 itemOne, T2 itemTwo)
        {
            ItemOne = itemOne;
            ItemTwo = itemTwo;
        }

        public T1 ItemOne { get; set; }

        public T2 ItemTwo { get; set; }

        public override string ToString()
        {
            return $"{ItemOne} -> {ItemTwo}";
        }
    }
}
