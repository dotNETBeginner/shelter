using System;
using System.Collections.Generic;
using System.Text;

namespace задание_6_лаба_10
{
    class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }

        public Person(string name, int age)
        {
            Age = age;
            Name = name;
        }

        public void Display() => Console.WriteLine($"{Name} {Age}");
    }
}
