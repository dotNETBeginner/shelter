using System;
using System.Collections.Generic;
using System.Text;

namespace задание_5_лаба_10
{
    class Person : IComparable<Person>
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Town { get; set; }

        public Person(string name, int age, string town)
        {
            Name = name;
            Age = age;
            Town = town;
        }

        public int CompareTo(Person t)
        {
            if(Name == t.Name && Age == t.Age && Town == t.Town)
            { return 1; }
            else
            { return 0; }
        }

    }
}
