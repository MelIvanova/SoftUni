using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DefiningClasses
{
   public class Family
    {
        public Family()
        {
            Clan = new List<Person>();
        }
        
        public List<Person> Clan { get; set; }

        public void AddMember (Person member)
        { 
           Clan.Add(member);
        }

        public Person GetOldestMember ()
        {
            Person oldest = Clan.OrderByDescending(p => p.Age).FirstOrDefault();

            return oldest;
        }
    }
}
