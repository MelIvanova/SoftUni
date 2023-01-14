using System;
using System.Collections.Generic;
using System.Text;

namespace GenericBoxString
{
    public class Box<T>
        where T : IComparable, IConvertible
    {
        public Box(T value)
        {
            Value = value;
        }

        public T Value { get; set; }

        public override string ToString()
        {
            return $"{Value.GetType()}: {Value}";
        }
    }
}
