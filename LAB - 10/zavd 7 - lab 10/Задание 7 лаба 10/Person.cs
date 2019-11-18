using System;
using System.Collections.Generic;
using System.Text;

namespace Задание_7_лаба_10
{
    class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public override int GetHashCode()
        {
            int result = 0;

            for(int i=0; i<Name.Length; i++)
            { result += Name[i]; }

            result += Age;

            return result;
        }

        public override bool Equals(object obj)
        {
            Person n = (Person)obj;

            return this.GetHashCode() == n.GetHashCode() && (this.GetHashCode() - this.Age) == (n.GetHashCode() - n.Age) && this.Age == n.Age;
        }

        public void Display() => Console.WriteLine($"{Name} {Age}");
    }
}
