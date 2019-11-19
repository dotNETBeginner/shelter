using System;
using System.Collections.Generic;
using System.Text;

namespace задание_8_лаба_10
{
    class Pet
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Kind { get; set; }

        public Pet(string name, int age, string kind) 
        {
            Name = name;
            Age = age;
            Kind = kind;
        }
    }
}
