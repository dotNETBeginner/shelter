using System;
using System.Collections.Generic;
using System.Text;

namespace Задание_1__лаба_7_
{
    class Citizen : IPerson
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Citizen(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void Display() => Console.WriteLine($"{Name} is {Age} years old.");
        
    }
}
