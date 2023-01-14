using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using System.Xml.Linq;

namespace EqualityLogic
{
    public class Person : IComparable<Person>
    {
        private string name;

        private int age;


        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public int CompareTo(Person other)
        {
            
            if (name.CompareTo(other.name) != 0)
            {
                return name.CompareTo(other.name);
            }

            if (age.CompareTo(other.age) != 0)
            {
                return age.CompareTo(other.age);
            }

            return 0;
        }

        public override bool Equals(object other)
        {
            return GetHashCode() == other.GetHashCode();
        }

        public override int GetHashCode()
        {
            int nameHash = name.GetHashCode();
            int ageHash = age.GetHashCode();

            return nameHash + ageHash;
        }
    }
}
