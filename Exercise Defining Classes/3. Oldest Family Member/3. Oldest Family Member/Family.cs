using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{

    public class Family
    {
        private List<Person> member;

        public Family()
        {
            this.member = new List<Person>();
        }

        public List<Person> Member { get; set; }

        public void AddMember(Person member)
        {
            this.member.Add(member);
        }

        public Person GetOldestMember()
        {
            return this.member.MaxBy(x => x.Age);
        }
    }

}